using System;

namespace Labs
{
    class Neuron
    {
        private decimal weight = 0.5m;
        public decimal LastError{ get; private set; }
        public decimal Smoothing{ get; set; } = 0.00001m;

        public decimal ProcessInputData(decimal input)
        {
            return input * weight;
        }
        public void Train(decimal input, decimal expectedResult)
        {
            do
            {
                var actualResult = ProcessInputData(input);
                LastError = expectedResult - actualResult;
                var correction = (LastError / actualResult) * Smoothing;
                weight += correction;
            } while (LastError > Smoothing || LastError < -Smoothing);

        }
    }
}