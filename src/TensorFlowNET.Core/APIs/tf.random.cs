﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tensorflow
{
    public static partial class tf
    {
        /// <summary>
        /// Outputs random values from a normal distribution.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="mean"></param>
        /// <param name="stddev"></param>
        /// <param name="dtype"></param>
        /// <param name="seed"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Tensor random_normal(int[] shape,
            float mean = 0.0f,
            float stddev = 1.0f,
            TF_DataType dtype = TF_DataType.TF_FLOAT,
            int? seed = null,
            string name = "") => random_ops.random_normal(shape, mean, stddev, dtype, seed, name);
    }
}
