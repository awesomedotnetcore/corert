// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System
{
    public readonly partial struct DateTime
    {
        public static DateTime UtcNow
        {
            get
            {
                // For performance, use a private constructor that does not validate arguments.
                return new DateTime(((ulong)(Interop.Sys.GetSystemTimeAsTicks() + DateTime.UnixEpochTicks)) | KindUtc);
            }
        }
    }
}
