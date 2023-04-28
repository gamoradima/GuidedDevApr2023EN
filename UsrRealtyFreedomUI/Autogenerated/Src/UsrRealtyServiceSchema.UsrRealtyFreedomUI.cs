﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3784ea2e-34ca-4ef2-84d5-ec866edf0c1e");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2d445756-a7bc-49c9-b8f5-ce9507582082");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,60,43,64,254,129,213,73,6,92,161,189,54,77,1,187,177,13,183,72,108,68,14,114,48,122,96,164,117,34,148,15,133,92,166,17,26,255,123,151,34,157,202,125,184,200,173,23,61,118,135,179,51,67,82,113,9,182,225,37,176,21,24,195,173,222,96,254,81,171,77,125,235,12,199,90,171,227,163,239,199,71,137,179,181,186,101,69,107,17,100,94,128,121,168,75,56,215,21,136,147,67,205,252,26,110,14,3,70,37,214,15,221,156,159,184,190,16,3,249,217,248,79,45,98,166,182,148,253,133,97,192,111,3,61,180,0,107,105,72,129,28,193,3,214,81,5,89,69,195,75,252,226,107,35,219,92,0,18,107,67,138,110,106,81,99,123,9,247,174,54,32,65,161,205,250,63,94,62,59,101,255,88,226,81,121,44,84,3,63,164,113,55,162,46,89,41,184,181,236,18,184,192,54,74,97,239,216,152,91,136,127,67,54,167,110,181,80,162,237,107,39,6,191,29,201,122,209,64,216,159,190,131,100,77,94,231,234,65,127,133,236,28,240,78,87,36,49,93,46,138,85,58,100,99,93,181,5,182,194,203,38,216,57,177,242,91,120,174,230,215,134,55,13,84,67,207,147,120,205,96,113,170,141,228,184,183,32,148,242,79,86,171,33,25,176,141,86,22,14,227,188,113,207,26,189,87,80,214,146,11,54,3,92,105,228,98,36,181,83,56,110,87,109,3,243,42,179,104,252,230,153,46,155,80,27,178,189,226,98,179,1,19,59,157,218,216,165,196,41,255,11,58,209,3,95,238,130,74,234,13,139,148,249,220,94,56,33,22,102,34,27,108,179,254,128,1,123,122,98,7,80,189,137,29,117,146,252,13,223,211,16,144,65,69,98,0,157,81,236,245,219,147,238,127,219,61,119,73,24,176,78,248,248,222,132,110,1,2,74,100,54,188,78,153,130,111,44,212,178,43,11,134,182,92,209,55,109,126,20,67,55,65,56,169,178,169,83,101,94,56,153,165,87,214,44,13,29,163,171,226,44,29,236,80,83,163,101,246,75,72,84,190,190,3,3,221,146,224,48,29,144,167,201,189,227,34,11,188,249,146,27,194,35,152,204,43,153,185,186,218,79,239,121,194,72,85,29,81,47,175,23,176,245,83,222,81,114,27,157,135,100,158,147,10,217,228,147,71,40,29,66,81,114,193,205,251,152,231,135,108,176,67,119,161,135,69,93,105,251,210,203,51,155,252,87,119,39,158,116,186,58,147,71,46,27,1,89,239,168,71,187,233,226,243,171,116,231,150,94,244,220,254,0,175,45,231,117,231,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3784ea2e-34ca-4ef2-84d5-ec866edf0c1e"));
		}

		#endregion

	}

	#endregion

}
