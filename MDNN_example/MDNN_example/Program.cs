using My_DNN.Layers;
using My_DNN.Layers.classes;
using My_DNN.Optimizers;
using My_DNN;
using My_DNN.Activation_functions;
using System.Xml.Schema;
using ScottPlot;
using My_DNN.Loss_functions;

namespace MDNN_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The goal is to train a neural network that will always have an output if the middle bit is 1. The test data are 010 where the output must be 1.

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

            uint epoch = 1000;

            MDNN model = new MDNN(outputLayer, optimizer, loss);

            Tensor tensorInputDataset = new Tensor(Tensor.ConvertJaggedToMulti(inputsDataset));
            Tensor tensorOutputDataset = new Tensor(Tensor.ConvertJaggedToMulti(ouputDataset));

            model.Train.TrainLoop(tensorInputDataset, tensorOutputDataset, epoch,1);

        }
    }
}
