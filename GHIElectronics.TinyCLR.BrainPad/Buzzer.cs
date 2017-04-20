﻿using GHIElectronics.TinyCLR.Devices.Pwm;
using GHIElectronics.TinyCLR.Pins;
using System.Threading;

namespace GHIElectronics.TinyCLR.BrainPad.Internal {
    public class Buzzer {
        private PwmController controller;
        private PwmPin buzz;

        public Buzzer() {
            this.controller = PwmController.FromId(G30.PwmPin.Controller4.Id);
            this.buzz = this.controller.OpenPin(G30.PwmPin.Controller4.PB8);
        }

        /// <summary>
        /// Starts a given frequency.
        /// </summary>
        /// <param name="frequency">The frequency to play.</param>
        public void Start(double frequency) {
            Stop();
            if (frequency > 0) {
                this.controller.SetDesiredFrequency(frequency);
                this.buzz.Start();
                this.buzz.SetActiveDutyCyclePercentage(0.5);
            }
        }

        /// <summary>
        /// Makes a short beep sound.
        /// </summary>
        public void Beep() {
            Start(2000);
            Thread.Sleep(5);
            Stop();
        }

        /// <summary>
        /// Stops any note or frequency currently playing.
        /// </summary>
        public void Stop() => this.buzz.Stop();
    }
}