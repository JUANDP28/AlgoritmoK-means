using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmoKmeans {
    class Element {
        public String name;
        public Double[] rows;
        public Double distance;


        public Element(string name, double row1, double row2, double row3, double row4) {
            this.name = name;
            this.rows = new Double[4] { row1, row2, row3, row4 };
            this.distance = 0.0;
        }
    }
}
