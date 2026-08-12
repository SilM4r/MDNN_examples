using My_DNN;
using My_DNN.Activation_functions;
using My_DNN.Layers;
using My_DNN.Layers.classes;
using My_DNN.Loss_functions;
using My_DNN.Optimizers;

namespace MDNN_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Úloha: naučit síť, že výstup je 1 právě když je prostřední bit 1.
            // Kombinace 0,1,0 se schválně NEUČÍ — na ní se na konci ověří, jestli
            // se síť naučila pravidlo, nebo jen odříkává trénovací data.

            double[][] inputsDataset = new double[][] { new double[] { 0, 0, 0},
                                                        new double[] { 0, 0, 1},
                                                        new double[] { 0, 1, 1},
                                                        new double[] { 1, 0, 0},
                                                        new double[] { 1, 0, 1},
                                                        new double[] { 1, 1, 0},
                                                        new double[] { 1, 1, 1}
                                                      };
            double[][] ouputDataset = new double[][] { new double[] { 0 },
                                                        new double[] { 0 },
                                                        new double[] { 1 },
                                                        new double[] { 0 },
                                                        new double[] { 0 },
                                                        new double[] { 1 },
                                                        new double[] { 1 }
                                                      };

            Layer outputLayer = new Dense(1, new Linear());
            Optimizer optimizer = new SGD(0.01);
            Loss loss = new MSE();

            // POZOR na význam: epocha = jeden PLNÝ průchod trénovacím setem, ne jeden krok
            // optimizeru. Na epochu tedy připadá tolik kroků, kolik je dávek.
            // Počet kroků najdeš v model.Train.OptimizerSteps.
            uint epoch = 1000;

            // seed = reprodukovatelnost: stejný běh dvakrát dá stejný výsledek
            MDNN model = new MDNN(outputLayer, optimizer, loss, seed: 42);

            // TrainLoop si dataset sám zamíchá a rozdělí na train / valid / test
            // v poměru 0.7 / 0.15 / 0.15.
            model.Train.TrainLoop(inputsDataset, ouputDataset, epoch, 1);

            // Vlastní pointa příkladu: vyzkoušet kombinaci, kterou síť při tréninku neviděla.
            double[] unseen = { 0, 1, 0 };
            double prediction = model.GetResults(new Tensor(unseen)).Data[0];

            Console.WriteLine();
            Console.WriteLine($"Vstup 0,1,0 (při tréninku nebyl) -> {prediction:F4}, zaokrouhleno {Math.Round(prediction)}");
            Console.WriteLine("Očekáváme 1, protože prostřední bit je 1.");
            Console.WriteLine($"Epoch: {model.Train.CurrentEpoch}, kroků optimizeru: {model.Train.OptimizerSteps}");
        }
    }
}
