## 📂 Examples for the MDNN library

Runnable examples that use the [MDNN](https://github.com/SilM4r/MDNN) library for building and
training neural networks. Each example demonstrates a specific feature or model configuration.

### 📁 What is here

| Example | Shows |
|---|---|
| `MDNN_example` | Binary classification — the output is 1 exactly when the middle bit of the input is 1. Trains on 7 of the 8 possible inputs and then checks the one it never saw. |

### 🖥️ Building and running

The example projects reference the library by **relative path** and assume that `MDNN` and
`MDNN_examples` are cloned **next to each other**:

```
your-folder/
 ├── MDNN            <- the library
 └── MDNN_examples   <- this repository
```

With that layout:

```bash
git clone https://github.com/SilM4r/MDNN.git
git clone https://github.com/SilM4r/MDNN_examples.git

cd MDNN_examples/MDNN_example/MDNN_example
dotnet run
```

If you keep the library somewhere else, edit the `ProjectReference` in the `.csproj`, or
replace it with a `Reference` + `HintPath` pointing at your own `MDNN.dll`.

### ✅ Using an example in your own project

1. Create a new C# project (.NET 9).
2. Reference `MDNN.dll`, or add a `ProjectReference` to `MDNN.csproj`.
3. Copy the contents of the example's `Program.cs` into your own `Program.cs`.
4. If the example needs a dataset, place it where the code expects it.
5. Run.

### 📝 Notes

- Training writes `loss.png` (the loss curve) and, when auto-save is on, `AutoSave.json`
  (the best model so far) into the working directory. Both are ignored by git.
- A saved model can be loaded with `MDNN.LoadModel(path)` and used for inference without
  retraining.
