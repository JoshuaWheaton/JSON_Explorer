using System;
using System.Collections.Generic;

namespace JSON_Explorer
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Event
    {
        public int RegRead { get; set; }
        public int? MemRead { get; set; }
        public List<object> RegWrite { get; set; }
        public List<int> MemWrite { get; set; }
    }

    public class Info
    {
        public int mode { get; set; }
        public List<Register> registers { get; set; }
        public List<List<int>> memory { get; set; }
    }

    public class Instruction
    {
        public int addr { get; set; }
        public string insn { get; set; }
        public int? size { get; set; }
        public string kind { get; set; }
        public List<Event> events { get; set; }
    }

    public class Register
    {
        public string name { get; set; }
        public int register { get; set; }
        public int @base { get; set; }
        public object full_register { get; set; }
        public int size { get; set; }

        public int reg_val { get; set; } = 0;
    }

    public class Root
    {
        public Info info { get; set; }
        public List<Instruction> instructions { get; set; }
    }


}
