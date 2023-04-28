namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIEventsSchema(UsrRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0283c409-5e21-4427-bc6b-ea80a185cb87");
			Name = "UsrRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2d445756-a7bc-49c9-b8f5-ce9507582082");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,219,64,16,189,11,242,31,6,209,131,4,102,73,174,117,27,168,93,167,24,66,91,98,57,151,146,195,122,53,86,182,236,135,216,93,57,117,139,255,123,103,181,118,99,217,46,237,156,164,217,55,111,222,123,140,225,26,125,203,5,66,133,206,113,111,215,129,77,173,89,203,166,115,60,72,107,178,95,25,80,117,94,154,6,22,91,31,80,143,143,58,199,83,90,91,243,183,55,135,108,102,130,12,18,253,127,64,216,108,131,38,236,145,223,250,238,182,111,221,75,18,96,208,21,11,241,140,154,127,38,245,240,30,242,165,119,15,200,85,216,222,57,196,218,234,229,60,47,159,250,225,182,91,41,41,64,40,238,61,36,204,5,58,120,11,19,238,241,194,75,79,146,34,56,162,179,27,210,45,107,132,141,149,53,124,49,115,227,209,5,50,84,216,213,119,20,1,60,154,26,221,8,18,227,4,215,228,174,231,253,224,26,15,88,254,33,124,165,142,181,34,17,236,152,238,192,131,229,120,0,76,188,224,122,67,148,64,145,26,101,194,15,177,53,10,169,185,130,214,73,17,211,74,67,236,19,134,106,219,98,61,181,170,211,230,145,171,14,223,237,161,183,69,76,244,107,196,47,23,31,243,147,221,114,13,69,226,186,133,155,235,67,149,87,3,208,208,87,44,100,115,63,229,70,160,194,154,84,4,215,225,248,42,59,131,249,224,226,97,208,85,122,222,96,133,186,85,60,68,217,6,95,224,222,10,174,228,79,190,82,184,232,113,197,222,204,146,2,163,179,53,148,61,221,44,123,64,111,59,39,8,100,29,177,140,224,108,77,172,11,103,147,238,46,31,65,126,182,202,179,62,163,185,175,172,157,200,38,253,229,37,171,236,94,10,197,244,15,55,228,34,53,216,157,117,154,135,226,196,37,173,189,97,215,147,55,167,137,199,10,207,206,190,244,33,204,126,8,108,163,205,195,248,9,122,151,13,191,118,217,46,251,13,89,174,75,42,231,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("883c40ff-ba0d-d022-1d6d-ab3a1e0c2190"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("2d445756-a7bc-49c9-b8f5-ce9507582082"),
				CreatedInSchemaUId = new Guid("0283c409-5e21-4427-bc6b-ea80a185cb87"),
				ModifiedInSchemaUId = new Guid("0283c409-5e21-4427-bc6b-ea80a185cb87")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0283c409-5e21-4427-bc6b-ea80a185cb87"));
		}

		#endregion

	}

	#endregion

}

