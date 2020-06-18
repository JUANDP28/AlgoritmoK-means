using System;
using System.Collections.Generic;

namespace AlgoritmoKmeans {
    class Program {

        List<Element> irisDB = new List<Element>();
        List<Element> setosa = new List<Element>();
        List<Element> versicolor = new List<Element>();
        List<Element> virginica = new List<Element>();
        Element centroidA = null, centroidB = null, centroidC = null;

        public void LoadData() {
            irisDB.Add(new Element("Setosa", 5.1, 3.5, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 4.9, 3.0, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 4.7, 3.2, 1.3, 0.2));
            irisDB.Add(new Element("Setosa", 4.6, 3.1, 1.5, 0.2));
            irisDB.Add(new Element("Setosa", 5.0, 3.6, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 5.4, 3.9, 1.7, 0.4));
            irisDB.Add(new Element("Setosa", 4.6, 3.4, 1.4, 0.3));
            irisDB.Add(new Element("Setosa", 5.0, 3.4, 1.5, 0.2));
            irisDB.Add(new Element("Setosa", 4.4, 2.9, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 4.9, 3.1, 1.5, 0.1));
            irisDB.Add(new Element("Setosa", 5.4, 3.7, 1.5, 0.2));
            irisDB.Add(new Element("Setosa", 4.8, 3.4, 1.6, 0.2));
            irisDB.Add(new Element("Setosa", 4.8, 3.0, 1.4, 0.1));
            irisDB.Add(new Element("Setosa", 4.3, 3.0, 1.1, 0.1));
            irisDB.Add(new Element("Setosa", 5.8, 4.0, 1.2, 0.2));
            irisDB.Add(new Element("Setosa", 5.7, 4.4, 1.5, 0.4));
            irisDB.Add(new Element("Setosa", 5.4, 3.9, 1.3, 0.4));
            irisDB.Add(new Element("Setosa", 5.1, 3.5, 1.4, 0.3));
            irisDB.Add(new Element("Setosa", 5.7, 3.8, 1.7, 0.3));
            irisDB.Add(new Element("Setosa", 5.1, 3.8, 1.5, 0.3));
            irisDB.Add(new Element("Setosa", 5.4, 3.4, 1.7, 0.2));
            irisDB.Add(new Element("Setosa", 5.1, 3.7, 1.5, 0.4));
            irisDB.Add(new Element("Setosa", 4.6, 3.6, 1.0, 0.2));
            irisDB.Add(new Element("Setosa", 5.1, 3.3, 1.7, 0.5));
            irisDB.Add(new Element("Setosa", 4.8, 3.4, 1.9, 0.2));
            irisDB.Add(new Element("Setosa", 5.0, 3.0, 1.6, 0.2));
            irisDB.Add(new Element("Setosa", 5.0, 3.4, 1.6, 0.4));
            irisDB.Add(new Element("Setosa", 5.2, 3.5, 1.5, 0.2));
            irisDB.Add(new Element("Setosa", 5.2, 3.4, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 4.7, 3.2, 1.6, 0.2));
            irisDB.Add(new Element("Setosa", 4.8, 3.1, 1.6, 0.2));
            irisDB.Add(new Element("Setosa", 5.4, 3.4, 1.5, 0.4));
            irisDB.Add(new Element("Setosa", 5.2, 4.1, 1.5, 0.1));
            irisDB.Add(new Element("Setosa", 5.5, 4.2, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 4.9, 3.1, 1.5, 0.1));
            irisDB.Add(new Element("Setosa", 5.0, 3.2, 1.2, 0.2));
            irisDB.Add(new Element("Setosa", 5.5, 3.5, 1.3, 0.2));
            irisDB.Add(new Element("Setosa", 4.9, 3.1, 1.5, 0.1));
            irisDB.Add(new Element("Setosa", 4.4, 3.0, 1.3, 0.2));
            irisDB.Add(new Element("Setosa", 5.1, 3.4, 1.5, 0.2));
            irisDB.Add(new Element("Setosa", 5.0, 3.5, 1.3, 0.3));
            irisDB.Add(new Element("Setosa", 4.5, 2.3, 1.3, 0.3));
            irisDB.Add(new Element("Setosa", 4.4, 3.2, 1.3, 0.2));
            irisDB.Add(new Element("Setosa", 5.0, 3.5, 1.6, 0.6));
            irisDB.Add(new Element("Setosa", 5.1, 3.8, 1.9, 0.4));
            irisDB.Add(new Element("Setosa", 4.8, 3.0, 1.4, 0.3));
            irisDB.Add(new Element("Setosa", 5.1, 3.8, 1.6, 0.2));
            irisDB.Add(new Element("Setosa", 4.6, 3.2, 1.4, 0.2));
            irisDB.Add(new Element("Setosa", 5.3, 3.7, 1.5, 0.2));
            irisDB.Add(new Element("Setosa", 5.0, 3.3, 1.4, 0.2));
            irisDB.Add(new Element("Versicolor", 7.0, 3.2, 4.7, 1.4));
            irisDB.Add(new Element("Versicolor", 6.4, 3.2, 4.5, 1.5));
            irisDB.Add(new Element("Versicolor", 6.9, 3.1, 4.9, 1.5));
            irisDB.Add(new Element("Versicolor", 5.5, 2.3, 4.0, 1.3));
            irisDB.Add(new Element("Versicolor", 6.5, 2.8, 4.6, 1.5));
            irisDB.Add(new Element("Versicolor", 5.7, 2.8, 4.5, 1.3));
            irisDB.Add(new Element("Versicolor", 6.3, 3.3, 4.7, 1.6));
            irisDB.Add(new Element("Versicolor", 4.9, 2.4, 3.3, 1.0));
            irisDB.Add(new Element("Versicolor", 6.6, 2.9, 4.6, 1.3));
            irisDB.Add(new Element("Versicolor", 5.2, 2.7, 3.9, 1.4));
            irisDB.Add(new Element("Versicolor", 5.0, 2.0, 3.5, 1.0));
            irisDB.Add(new Element("Versicolor", 5.9, 3.0, 4.2, 1.5));
            irisDB.Add(new Element("Versicolor", 6.0, 2.2, 4.0, 1.0));
            irisDB.Add(new Element("Versicolor", 6.1, 2.9, 4.7, 1.4));
            irisDB.Add(new Element("Versicolor", 5.6, 2.9, 3.6, 1.3));
            irisDB.Add(new Element("Versicolor", 6.7, 3.1, 4.4, 1.4));
            irisDB.Add(new Element("Versicolor", 5.6, 3.0, 4.5, 1.5));
            irisDB.Add(new Element("Versicolor", 5.8, 2.7, 4.1, 1.0));
            irisDB.Add(new Element("Versicolor", 6.2, 2.2, 4.5, 1.5));
            irisDB.Add(new Element("Versicolor", 5.6, 2.5, 3.9, 1.1));
            irisDB.Add(new Element("Versicolor", 5.9, 3.2, 4.8, 1.8));
            irisDB.Add(new Element("Versicolor", 6.1, 2.8, 4.0, 1.3));
            irisDB.Add(new Element("Versicolor", 6.3, 2.5, 4.9, 1.5));
            irisDB.Add(new Element("Versicolor", 6.1, 2.8, 4.7, 1.2));
            irisDB.Add(new Element("Versicolor", 6.4, 2.9, 4.3, 1.3));
            irisDB.Add(new Element("Versicolor", 6.6, 3.0, 4.4, 1.4));
            irisDB.Add(new Element("Versicolor", 6.8, 2.8, 4.8, 1.4));
            irisDB.Add(new Element("Versicolor", 6.7, 3.0, 5.0, 1.7));
            irisDB.Add(new Element("Versicolor", 6.0, 2.9, 4.5, 1.5));
            irisDB.Add(new Element("Versicolor", 5.7, 2.6, 3.5, 1.0));
            irisDB.Add(new Element("Versicolor", 5.5, 2.4, 3.8, 1.1));
            irisDB.Add(new Element("Versicolor", 5.5, 2.4, 3.7, 1.0));
            irisDB.Add(new Element("Versicolor", 5.8, 2.7, 3.9, 1.2));
            irisDB.Add(new Element("Versicolor", 6.0, 2.7, 5.1, 1.6));
            irisDB.Add(new Element("Versicolor", 5.4, 3.0, 4.5, 1.5));
            irisDB.Add(new Element("Versicolor", 6.0, 3.4, 4.5, 1.6));
            irisDB.Add(new Element("Versicolor", 6.7, 3.1, 4.7, 1.5));
            irisDB.Add(new Element("Versicolor", 6.3, 2.3, 4.4, 1.3));
            irisDB.Add(new Element("Versicolor", 5.6, 3.0, 4.1, 1.3));
            irisDB.Add(new Element("Versicolor", 5.5, 2.5, 4.0, 1.3));
            irisDB.Add(new Element("Versicolor", 5.5, 2.6, 4.4, 1.2));
            irisDB.Add(new Element("Versicolor", 6.1, 3.0, 4.6, 1.4));
            irisDB.Add(new Element("Versicolor", 5.8, 2.6, 4.0, 1.2));
            irisDB.Add(new Element("Versicolor", 5.0, 2.3, 3.3, 1.0));
            irisDB.Add(new Element("Versicolor", 5.6, 2.7, 4.2, 1.3));
            irisDB.Add(new Element("Versicolor", 5.7, 3.0, 4.2, 1.2));
            irisDB.Add(new Element("Versicolor", 5.7, 2.9, 4.2, 1.3));
            irisDB.Add(new Element("Versicolor", 6.2, 2.9, 4.3, 1.3));
            irisDB.Add(new Element("Versicolor", 5.1, 2.5, 3.0, 1.1));
            irisDB.Add(new Element("Versicolor", 5.7, 2.8, 4.1, 1.3));
            irisDB.Add(new Element("Virginica", 6.3, 3.3, 6.0, 2.5));
            irisDB.Add(new Element("Virginica", 5.8, 2.7, 5.1, 1.9));
            irisDB.Add(new Element("Virginica", 7.1, 3.0, 5.9, 2.1));
            irisDB.Add(new Element("Virginica", 6.3, 2.9, 5.6, 1.8));
            irisDB.Add(new Element("Virginica", 6.5, 3.0, 5.8, 2.2));
            irisDB.Add(new Element("Virginica", 7.6, 3.0, 6.6, 2.1));
            irisDB.Add(new Element("Virginica", 4.9, 2.5, 4.5, 1.7));
            irisDB.Add(new Element("Virginica", 7.3, 2.9, 6.3, 1.8));
            irisDB.Add(new Element("Virginica", 6.7, 2.5, 5.8, 1.8));
            irisDB.Add(new Element("Virginica", 7.2, 3.6, 6.1, 2.5));
            irisDB.Add(new Element("Virginica", 6.5, 3.2, 5.1, 2.0));
            irisDB.Add(new Element("Virginica", 6.4, 2.7, 5.3, 1.9));
            irisDB.Add(new Element("Virginica", 6.8, 3.0, 5.5, 2.1));
            irisDB.Add(new Element("Virginica", 5.7, 2.5, 5.0, 2.0));
            irisDB.Add(new Element("Virginica", 5.8, 2.8, 5.1, 2.4));
            irisDB.Add(new Element("Virginica", 6.4, 3.2, 5.3, 2.3));
            irisDB.Add(new Element("Virginica", 6.5, 3.0, 5.5, 1.8));
            irisDB.Add(new Element("Virginica", 7.7, 3.8, 6.7, 2.2));
            irisDB.Add(new Element("Virginica", 7.7, 2.6, 6.9, 2.3));
            irisDB.Add(new Element("Virginica", 6.0, 2.2, 5.0, 1.5));
            irisDB.Add(new Element("Virginica", 6.9, 3.2, 5.7, 2.3));
            irisDB.Add(new Element("Virginica", 5.6, 2.8, 4.9, 2.0));
            irisDB.Add(new Element("Virginica", 7.7, 2.8, 6.7, 2.0));
            irisDB.Add(new Element("Virginica", 6.3, 2.7, 4.9, 1.8));
            irisDB.Add(new Element("Virginica", 6.7, 3.3, 5.7, 2.1));
            irisDB.Add(new Element("Virginica", 7.2, 3.2, 6.0, 1.8));
            irisDB.Add(new Element("Virginica", 6.2, 2.8, 4.8, 1.8));
            irisDB.Add(new Element("Virginica", 6.1, 3.0, 4.9, 1.8));
            irisDB.Add(new Element("Virginica", 6.4, 2.8, 5.6, 2.1));
            irisDB.Add(new Element("Virginica", 7.2, 3.0, 5.8, 1.6));
            irisDB.Add(new Element("Virginica", 7.4, 2.8, 6.1, 1.9));
            irisDB.Add(new Element("Virginica", 7.9, 3.8, 6.4, 2.0));
            irisDB.Add(new Element("Virginica", 6.4, 2.8, 5.6, 2.2));
            irisDB.Add(new Element("Virginica", 6.3, 2.8, 5.1, 1.5));
            irisDB.Add(new Element("Virginica", 6.1, 2.6, 5.6, 1.4));
            irisDB.Add(new Element("Virginica", 7.7, 3.0, 6.1, 2.3));
            irisDB.Add(new Element("Virginica", 6.3, 3.4, 5.6, 2.4));
            irisDB.Add(new Element("Virginica", 6.4, 3.1, 5.5, 1.8));
            irisDB.Add(new Element("Virginica", 6.0, 3.0, 4.8, 1.8));
            irisDB.Add(new Element("Virginica", 6.9, 3.1, 5.4, 2.1));
            irisDB.Add(new Element("Virginica", 6.7, 3.1, 5.6, 2.4));
            irisDB.Add(new Element("Virginica", 6.9, 3.1, 5.1, 2.3));
            irisDB.Add(new Element("Virginica", 5.8, 2.7, 5.1, 1.9));
            irisDB.Add(new Element("Virginica", 6.8, 3.2, 5.9, 2.3));
            irisDB.Add(new Element("Virginica", 6.7, 3.3, 5.7, 2.5));
            irisDB.Add(new Element("Virginica", 6.7, 3.0, 5.2, 2.3));
            irisDB.Add(new Element("Virginica", 6.3, 2.5, 5.0, 1.9));
            irisDB.Add(new Element("Virginica", 6.5, 3.0, 5.2, 2.0));
            irisDB.Add(new Element("Virginica", 6.2, 3.4, 5.4, 2.3));
            irisDB.Add(new Element("Virginica", 5.9, 3.0, 5.1, 1.8));
        }

        public Boolean SelectCentroid() {
            Random random = new Random();
            Element auxiliaryA, auxiliaryB, auxiliaryC;
            if(centroidA == null) {
                auxiliaryA = GetElement(irisDB, random.Next(1, 151));
                auxiliaryB = GetElement(irisDB, random.Next(1, 151));
                auxiliaryC = GetElement(irisDB, random.Next(1, 151));
            } else {
                auxiliaryA = GetElementWithDistance(setosa);
                auxiliaryB = GetElementWithDistance(versicolor);
                auxiliaryC = GetElementWithDistance(virginica);
            }
            if(centroidA != null) {
                if(centroidA.Equals(auxiliaryA) && centroidB.Equals(auxiliaryB) && centroidC.Equals(auxiliaryC)) {
                    return true;
                } else {
                    setosa.Clear();
                    versicolor.Clear();
                    virginica.Clear();
                    centroidA = auxiliaryA;
                    centroidB = auxiliaryB;
                    centroidC = auxiliaryC;
                    return false;
                }
            } else {
                setosa.Clear();
                versicolor.Clear();
                virginica.Clear();
                centroidA = auxiliaryA;
                centroidB = auxiliaryB;
                centroidC = auxiliaryC;
                return false;
            }
        }

        public Element GetElementWithDistance(List<Element> list) {
            Double sumDistance = 0.0, halfDistance;
            foreach(Element element in list) {
                sumDistance += element.distance;
            }
            halfDistance = sumDistance / list.Count;
            foreach(Element element in list) {
                if(element.distance == halfDistance) {
                    return element;
                }
            }
            int position = 1, closenessElement = 0;
            Double closeness = 0.0;
            foreach(Element element in list) {
                if(position == 1) {
                    closeness = ((halfDistance - element.distance) * -1);
                    closenessElement = position;
                } else {
                    if(closeness > ((halfDistance - element.distance) * -1)) {
                        closeness = ((halfDistance - element.distance) * -1);
                        closenessElement = position;
                    }
                }
            }
            return GetElement(list, closenessElement);
        }

        public Element GetElement(List<Element> list, int position) {
            int accountant = 1;
            foreach(Element element in list) {
                if(accountant == position) {
                    return element;
                } else {
                    accountant++;
                }
            }
            return null;
        }

        public void CreateClusters() {
            Double distanceA, distanceB, distanceC;
            foreach(Element element in irisDB) {
                distanceA = CalculateDistance(centroidA, element);
                distanceB = CalculateDistance(centroidB, element);
                distanceC = CalculateDistance(centroidC, element);
                if(distanceA < distanceB && distanceA < distanceC) {
                    element.distance = distanceA;
                    setosa.Add(element);
                } else {
                    if(distanceB < distanceA && distanceB < distanceC) {
                        element.distance = distanceB;
                        versicolor.Add(element);
                    } else {
                        element.distance = distanceC;
                        virginica.Add(element);
                    }
                }
            }
        }

        public Double CalculateDistance(Element elementP, Element elementE) {
            double sum = 0;
            for(int i = 0; i < elementP.rows.Length; i++) {
                sum += Math.Pow((elementP.rows[i] - elementE.rows[i]), 2);
            }
            return Math.Sqrt(sum);
        }

        public void PrintClustering() {
            Console.WriteLine("");
            Console.WriteLine("SSE: " + NumberOfErrors());
            Console.WriteLine("SETOSA: " + setosa.Count);
            Console.WriteLine("VERSICOLOR: " + versicolor.Count);
            Console.WriteLine("VIRGINICA: " + virginica.Count);
            Console.WriteLine();
            setosa.Clear();
            versicolor.Clear();
            virginica.Clear();
        }

        public int NumberOfErrors() {
            int errors = 0;
            foreach(Element element in setosa) {
                if(element.name != "Setosa") {
                    errors++;
                }
            }
            foreach(Element element in versicolor) {
                if(element.name != "Versicolor") {
                    errors++;
                }
            }
            foreach(Element element in virginica) {
                if(element.name != "Virginica") {
                    errors++;
                }
            }
            return errors;
        }

        static void Main(string[] args) {
            Console.WriteLine("");
            Console.WriteLine("=============== ALGORITMO K-MEANS ===============");
            Console.WriteLine("");
            for(int i = 0; i < 10; i++) {
                Console.WriteLine("NÚMERO DE EJECUCIÓN: " + (i + 1));
                Program algorithm = new Program();
                algorithm.LoadData();
                while(algorithm.SelectCentroid() != true) {
                    algorithm.CreateClusters();
                }
                algorithm.PrintClustering();
            }
        }
    }
}
