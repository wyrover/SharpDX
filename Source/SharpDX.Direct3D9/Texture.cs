// Copyright (c) 2010-2011 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace SharpDX.Direct3D9
{
    public partial class Texture
    {
        public Texture(Device device, int width, int height, int levelCount, Usage usage, Format format, Pool pool) : base(IntPtr.Zero)
        {
            device.CreateTexture(width, height, levelCount, (int)usage, format, pool, this, IntPtr.Zero);
        }
        
        public Texture(Device device, int width, int height, int levelCount, Usage usage, Format format, Pool pool, ref IntPtr sharedHandle) : base(IntPtr.Zero)
        {
            unsafe
            {
                // TODO, fix param shraredHandle
                fixed (void* pSharedHandle = &sharedHandle)
                    device.CreateTexture(width, height, levelCount, (int)usage, format, pool, this, new IntPtr(pSharedHandle));
            }
        }
    }
}