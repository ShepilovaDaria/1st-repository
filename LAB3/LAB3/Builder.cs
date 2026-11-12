using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3.Builder
{
    public class Computer// продукт
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }
        public override string ToString() => $"Computer{{CPU='{CPU}', RAM='{RAM}', GPU='{GPU}'}}";

    }
    //Интерфейс
    public interface Computerbuilder
    {
        void BuildCPU();
        void BuildRAM();
        void BuildGPU();
        Computer Getresult();
    }
    public class StreamingComputerbuilder : Computerbuilder //конкретные строители
    {
        private readonly Computer computer = new Computer();
        public void BuildCPU() => computer.CPU = "Intel.Core Ultra 7";
        public void BuildRAM() => computer.RAM = "64GB,DDR5";
        public void BuildGPU() => computer.GPU = "NVIDIA RTX 5080";
        public Computer Getresult() => computer;
    }

    public class OfficeComputerbuilder : Computerbuilder
    {
        private readonly Computer computer = new Computer();
        public void BuildCPU() => computer.CPU = "Intel.Core i3";
        public void BuildRAM() => computer.RAM = "8GB,DDR4";
        public void BuildGPU() => computer.GPU = "Integrated graphics";
        public Computer Getresult() => computer;
    }
    //задаёт порядок шагов
    public class ComputerDirector
    {
        private readonly Computerbuilder builder;
        public ComputerDirector(Computerbuilder builder)
        {
            this.builder = builder;
        }
        public void Constructcomputer()
        {
            builder.BuildCPU();
            builder.BuildRAM();
            builder.BuildGPU();
        }
    }
}
