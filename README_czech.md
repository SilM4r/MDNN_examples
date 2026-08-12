## 📂 Ukázky použití knihovny MDNN

Spustitelné příklady, které používají knihovnu [MDNN](https://github.com/SilM4r/MDNN) pro
vytváření a trénování neuronových sítí. Každý příklad ukazuje konkrétní funkcionalitu nebo
konfiguraci modelu.

### 📁 Co tu je

| Příklad | Co ukazuje |
|---|---|
| `MDNN_example` | Binární klasifikace — výstup je 1 právě když je prostřední bit vstupu 1. Trénuje se na 7 z 8 možných vstupů a na konci se vyzkouší ten, který síť nikdy neviděla. |

### 🖥️ Překlad a spuštění

Projekty odkazují na knihovnu **relativní cestou** a předpokládají, že `MDNN`
a `MDNN_examples` jsou naklonované **vedle sebe**:

```
tvoje-slozka/
 ├── MDNN            <- knihovna
 └── MDNN_examples   <- tenhle repozitář
```

Při tomhle uspořádání:

```bash
git clone https://github.com/SilM4r/MDNN.git
git clone https://github.com/SilM4r/MDNN_examples.git

cd MDNN_examples/MDNN_example/MDNN_example
dotnet run
```

Když máš knihovnu jinde, uprav `ProjectReference` v `.csproj`, nebo ho nahraď
`Reference` + `HintPath` na svoji `MDNN.dll`.

### ✅ Použití příkladu ve vlastním projektu

1. Vytvoř nový C# projekt (.NET 9).
2. Přidej odkaz na `MDNN.dll`, nebo `ProjectReference` na `MDNN.csproj`.
3. Zkopíruj obsah `Program.cs` z příkladu do svého `Program.cs`.
4. Pokud příklad potřebuje dataset, dej ho tam, kde ho kód čeká.
5. Spusť.

### 📝 Poznámky

- Trénink zapisuje do pracovního adresáře `loss.png` (graf ztráty) a při zapnutém
  auto-save i `AutoSave.json` (dosud nejlepší model). Obojí je v `.gitignore`.
- Uložený model jde načíst přes `MDNN.LoadModel(cesta)` a použít pro inference
  bez opětovného trénování.
