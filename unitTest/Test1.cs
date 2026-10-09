using mainApp;

namespace unitTest
{
    [TestClass]
    public sealed class MachineConfigTests
    {
        /// <summary>
        /// Verifies that only canonical dotted IPv4 addresses are accepted,
        /// and that dotless / shorthand / octal / out-of-range forms are rejected.
        /// </summary>
        [TestMethod]
        public void IsIpv4AddressValidFormat()
        {
            Assert.IsTrue(MachineConfig.IsIpv4AddressValid("192.168.1.10"));

            Assert.IsTrue(MachineConfig.IsIpv4AddressValid("127.0.0.1"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid("192168110"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid("127.1"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid("010.0.0.1"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid("192.168.1"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid("999.1.1.1"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid("::1"));

            Assert.IsFalse(MachineConfig.IsIpv4AddressValid(""));
        }

        /// <summary>
        /// verifies if ShouldSendMail is true only when the state change from functional to non functional or vice versa
        /// </summary>
        [TestMethod]
        public void ShouldSendMailOnlyOnFunctionalNonfunctionalTransitions()
        {
            Assert.IsTrue(Notifier.ShouldSendMail(CommunicationState.Functional, CommunicationState.NonFunctional));

            Assert.IsTrue(Notifier.ShouldSendMail(CommunicationState.NonFunctional, CommunicationState.Functional));

            Assert.IsFalse(Notifier.ShouldSendMail(CommunicationState.NonInitiated, CommunicationState.Functional));

            Assert.IsFalse(Notifier.ShouldSendMail(CommunicationState.NonInitiated, CommunicationState.NonFunctional));
        }

        /// <summary>
        /// checks that filtering keeps every valid machine and drops every invalid one
        /// </summary>
        [TestMethod]
        public void KeepsOnlyValidMachines()
        {
            Config config = new Config();

            MachineConfig valid = new MachineConfig();
            valid.Name = "srv";
            valid.Ipv4Address = "127.0.0.1";
            valid.PingRequestInterval = 2;

            MachineConfig invalid = new MachineConfig();
            invalid.Name = "bad";
            invalid.Ipv4Address = "1270001";
            invalid.PingRequestInterval = 3;

            config.Machines.Add(valid);
            config.Machines.Add(invalid);

            config.RemoveInvalidMachines();

            Assert.HasCount(1, config.Machines);
            Assert.AreSame(valid, config.Machines[0]);
        }
    }
}
