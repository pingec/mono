//
// SignerInfoCollection.cs - System.Security.Cryptography.Pkcs.SignerInfoCollection
//
// Author:
//	Sebastien Pouliot (spouliot@motus.com)
//
// (C) 2003 Motus Technologies Inc. (http://www.motus.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0

using System;
using System.Collections;

namespace System.Security.Cryptography.Pkcs {

	public class SignerInfoCollection : ICollection {

		private ArrayList _list;

		// only accessible from SignedPkcs7.SignerInfos or SignerInfo.CounterSignerInfos
		internal SignerInfoCollection () 
		{
			_list = new ArrayList ();
		}

		// properties

		public int Count {
			get { return _list.Count; }
		}

		public bool IsSynchronized {
			get { return _list.IsSynchronized; }
		}

		public SignerInfo this [int index] {
			get { return (SignerInfo) _list [index]; }
		}

		public object SyncRoot {
			get { return _list.SyncRoot; }
		}

		// methods

		internal void Add (SignerInfo signer) 
		{
			_list.Add (signer);
		}

		public void CopyTo (Array array, int index) 
		{
			_list.CopyTo (array, index);
		}

		public void CopyTo (RecipientInfo[] array, int index) {}

		public SignerInfoEnumerator GetEnumerator ()
		{
			return new SignerInfoEnumerator (_list);
		}

		IEnumerator IEnumerable.GetEnumerator () 
		{
			return new SignerInfoEnumerator (_list);
		}
	}
}

#endif