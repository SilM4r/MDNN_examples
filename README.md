## 📂 Structure of Sample Programs

This directory contains a set of demonstration examples that use the **MDNN** library for creating and training neural networks. Each example is designed to showcase a specific functionality or model configuration.

### 🖥️ Running the Samples

The sample applications are ready to be run immediately within the **Visual Studio** development environment. After copying the relevant code into an existing project, simply build and run the project.

### 📁 Contents of Each Folder

Each folder contains the following files:

- **`program.txt`** – the source code demonstrating the use of the MDNN library. Simply copy this code into the main file (`Program.cs`) of your existing project.
- **`.json` file** – a serialized neural network model trained on the given dataset. The model is ready for immediate inference without the need for retraining.
- **`dataset.csv`** *(or other format)* – the dataset used for training the model.
- **`loss_plot.png`** – a visualization of the loss function value over the training epochs.

### ✅ Recommended Workflow

1. Create a new C# project in Visual Studio.
2. Load the **MDNN.dll** library and add the necessary references.
3. Copy the code from `program.txt` into the `Program.cs` file.
4. Make sure the dataset is placed in the correct project directory if needed.
5. Run the application.

This way, you can easily test and modify different usage scenarios of the **MDNN** library according to your needs.
