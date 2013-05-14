using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvolutionAlgo
{
    class AlgoSettings
    {

        public SelectionStrategy strategy;
        public StopCriterion[] stop;
        public uint populationSize;
        public uint crossoverCount;
        public float mutationRate;
        public int crossover;

        public AlgoSettings(SelectionStrategy strategy, StopCriterion stop, 
            uint populationSize, uint crossoverCount, float mutationRate, int crossover) {

                this.strategy = strategy;
                this.stop = stop;
                this.populationSize = populationSize;
                this.crossoverCount = crossoverCount;
                this.mutationRate = mutationRate;
                this.crossover = crossover;
            //Das ist ein Test
        }


    }
}
