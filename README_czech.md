## 📂 Struktura ukázkových programů

Tento adresář obsahuje sadu demonstračních příkladů, které využívají knihovnu **MDNN** pro vytvoření a trénování a neuronových sítí. Každý příklad je navržen tak, aby ukázal konkrétní funkcionalitu nebo konfiguraci modelu.

### 🖥️ Spuštění ukázek

Ukázkové aplikace jsou připraveny k okamžitému spuštění ve vývojovém prostředí **Visual Studio**. Po zkopírování příslušného kódu do existujícího projektu stačí projekt přeložit a spustit.

### 📁 Obsah jednotlivých složek

Každá složka obsahuje následující soubory:

- **`program.txt`** – zdrojový kód programu, který demonstruje použití knihovny MDNN. Tento kód stačí zkopírovat do hlavního souboru (`Program.cs`) v rámci již vytvořeného projektu.
- **`.json` soubor** – serializovaný model neuronové sítě natrénovaný na daném datasetu. Model je připraven k okamžité inference bez nutnosti opětovného trénování.
- **`dataset.csv`** *(nebo jiný formát)* – datová sada použitá pro trénování modelu.
- **`loss_plot.png`** – vizualizace průběhu hodnoty ztrátové funkce napříč jednotlivými epochami trénování.

### ✅ Doporučený postup

1. Vytvoř nový C# projekt ve Visual Studiu.
2. Načti knihovnu **MDNN.dll** a přidej potřebné odkazy.
3. Zkopíruj kód z `program.txt` do souboru `Program.cs`.
4. Ujisti se, že případný dataset se nachází ve správném adresáři projektu.
5. Spusť aplikaci.

Tímto způsobem můžeš snadno testovat a upravovat jednotlivé scénáře použití knihovny **MDNN** podle svých potřeb.

### 🔧 Překlad připraveného projektu

Projekt `MDNN_example` odkazuje na knihovnu **relativní cestou** a předpokládá, že `MDNN`
a `MDNN_examples` jsou naklonované **vedle sebe**:

```
tvoje-slozka/
 ├── MDNN            <- knihovna
 └── MDNN_examples   <- tenhle repozitář
```

```bash
cd MDNN_examples/MDNN_example/MDNN_example
dotnet run
```

Když máš knihovnu jinde, uprav `ProjectReference` v `.csproj`, nebo ho nahraď `Reference`
+ `HintPath` na svoji `MDNN.dll`.

Trénink zapisuje do pracovního adresáře `loss.png` a při zapnutém auto-save i `AutoSave.json`.
