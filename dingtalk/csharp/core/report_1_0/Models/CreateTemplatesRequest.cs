// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class CreateTemplatesRequest : TeaModel {
        [NameInMap("allowAddReceivers")]
        [Validation(Required=false)]
        public bool? AllowAddReceivers { get; set; }

        [NameInMap("allowEdit")]
        [Validation(Required=false)]
        public bool? AllowEdit { get; set; }

        [NameInMap("allowGetLocation")]
        [Validation(Required=false)]
        public bool? AllowGetLocation { get; set; }

        [NameInMap("authDeptIds")]
        [Validation(Required=false)]
        public List<string> AuthDeptIds { get; set; }

        [NameInMap("authUserIds")]
        [Validation(Required=false)]
        public List<string> AuthUserIds { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("defaultReceivedCids")]
        [Validation(Required=false)]
        public List<string> DefaultReceivedCids { get; set; }

        [NameInMap("defaultReceivedMasterLevels")]
        [Validation(Required=false)]
        public List<string> DefaultReceivedMasterLevels { get; set; }

        [NameInMap("defaultReceivers")]
        [Validation(Required=false)]
        public List<string> DefaultReceivers { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<CreateTemplatesRequestFields> Fields { get; set; }
        public class CreateTemplatesRequestFields : TeaModel {
            [NameInMap("dataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            [NameInMap("dataValue")]
            [Validation(Required=false)]
            public CreateTemplatesRequestFieldsDataValue DataValue { get; set; }
            public class CreateTemplatesRequestFieldsDataValue : TeaModel {
                [NameInMap("openInfo")]
                [Validation(Required=false)]
                public CreateTemplatesRequestFieldsDataValueOpenInfo OpenInfo { get; set; }
                public class CreateTemplatesRequestFieldsDataValueOpenInfo : TeaModel {
                    [NameInMap("attribute")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Attribute { get; set; }

                    [NameInMap("openId")]
                    [Validation(Required=false)]
                    public string OpenId { get; set; }

                }

                [NameInMap("options")]
                [Validation(Required=false)]
                public List<string> Options { get; set; }

                [NameInMap("placeholder")]
                [Validation(Required=false)]
                public string Placeholder { get; set; }

            }

            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("need")]
            [Validation(Required=false)]
            public bool? Need { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            [NameInMap("sort")]
            [Validation(Required=false)]
            public int? Sort { get; set; }

        }

        [NameInMap("logo")]
        [Validation(Required=false)]
        public string Logo { get; set; }

        [NameInMap("maxWordCount")]
        [Validation(Required=false)]
        public int? MaxWordCount { get; set; }

        [NameInMap("minWordCount")]
        [Validation(Required=false)]
        public int? MinWordCount { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("templateManagers")]
        [Validation(Required=false)]
        public List<string> TemplateManagers { get; set; }

    }

}
