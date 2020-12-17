﻿// Copyright (c) 2019-2020 Faber Leonardo. All Rights Reserved. https://github.com/FaberSanZ
// This code is licensed under the MIT license (MIT) (http://opensource.org/licenses/MIT)

/*=============================================================================
	VertexAttribute.cs
=============================================================================*/


using System;

namespace Zeckoxe.Graphics
{
    public class VertexAttribute : Attribute
    {
        public PixelFormat Format;
        public VertexAttributeType Type;

        public VertexAttribute(VertexAttributeType type, PixelFormat format)
        {
            Format = format;
            Type = type;
        }
    }
}
