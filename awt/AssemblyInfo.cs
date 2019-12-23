/*
  Copyright (C) 2002-2010 Jeroen Frijters

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

  Jeroen Frijters
  jeroen@frijters.net
  
*/
using System.Reflection;
using System.Runtime.CompilerServices;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("IKVM.NET AWT Support")]
[assembly: AssemblyDescription("Winforms peers and 'native' code")]

[assembly: System.Security.AllowPartiallyTrustedCallers]

#if SIGNCODE
[assembly: InternalsVisibleTo("IKVM.OpenJDK.SwingAWT, PublicKey=0024000004800000940000000602000000240000525341310004000001000100D52DB94FF1A0CC337264E7A70FD9D97706667394327D7927573D59AE003BF63A47CBBFB497FCFE234F854042800A8CBCA11A35E17FE12F0A021383AC0973541FF1648921C5CE72B7476138F311DD67BEBE3B1B3360A4D17A4BEC2A92514ACA3B7962D89B8FFFD7CAE5C436B5E17720987BBA72C85DFEF30A59F64D2D459912CB")]
#else
[assembly: InternalsVisibleTo("IKVM.OpenJDK.SwingAWT")]
#endif
