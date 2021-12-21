// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class CreateRelationMetaRequest : TeaModel {
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("relationMetaDTO")]
        [Validation(Required=false)]
        public CreateRelationMetaRequestRelationMetaDTO RelationMetaDTO { get; set; }
        public class CreateRelationMetaRequestRelationMetaDTO : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<CreateRelationMetaRequestRelationMetaDTOItems> Items { get; set; }
            public class CreateRelationMetaRequestRelationMetaDTOItems : TeaModel {
                public string ComponentName { get; set; }
                public CreateRelationMetaRequestRelationMetaDTOItemsProps Props { get; set; }
                public class CreateRelationMetaRequestRelationMetaDTOItemsProps : TeaModel {
                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("sortable")]
                    [Validation(Required=false)]
                    public bool? Sortable { get; set; }

                    [NameInMap("needDetail")]
                    [Validation(Required=false)]
                    public string NeedDetail { get; set; }

                    [NameInMap("labelEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? LabelEditableFreeze { get; set; }

                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    [NameInMap("requiredEditableFreeze")]
                    [Validation(Required=false)]
                    public bool? RequiredEditableFreeze { get; set; }

                    [NameInMap("notPrint")]
                    [Validation(Required=false)]
                    public string NotPrint { get; set; }

                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions> Options { get; set; }
                    public class CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions : TeaModel {
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("notUpper")]
                    [Validation(Required=false)]
                    public string NotUpper { get; set; }

                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }

                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public bool? Duration { get; set; }

                    [NameInMap("choice")]
                    [Validation(Required=false)]
                    public long? Choice { get; set; }

                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    [NameInMap("align")]
                    [Validation(Required=false)]
                    public string Align { get; set; }

                    [NameInMap("invisible")]
                    [Validation(Required=false)]
                    public bool? Invisible { get; set; }

                    [NameInMap("payEnable")]
                    [Validation(Required=false)]
                    public bool? PayEnable { get; set; }

                    [NameInMap("link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                }
            }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("relationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }
        };

        [NameInMap("tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

    }

}
