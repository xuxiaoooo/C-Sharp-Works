using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace forecast
{
    class KNN
    {
        public List<int> Labels;//结果列
        public List<double[]> Features;//属性列
        public int K;//K值
        public KNN(int k, List<int> labels, List<double[]> features)
        {
            K = k;
            Labels = labels;
            Features = features;
        }
        public void Classify(IEnumerable<double[]> data)
        {
            int n = Labels.Count;
            foreach (var line in data)
            {
                var dist = new Tuple<int, double>[n];
                for (int i = 0; i < n; i++)
                    dist[i] = Tuple.Create(Labels[i], Distance.Euclidean(line, Features[i]));
                var maxLabel = dist
                    .OrderBy(i => i.Item2)
                    .Take(K).GroupBy(i => i.Item1)
                    .OrderByDescending(i => i.Count())
                    .First().Key;
                Labels.Add(maxLabel);
                Features.Add(line);
                n++;
            }//计算点对距离
        }
        public int Display()
        {
            return Labels[Labels.Count - 1];//输出结果
        }
    }
}
