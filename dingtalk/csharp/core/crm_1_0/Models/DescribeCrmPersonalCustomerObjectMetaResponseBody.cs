// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DescribeCrmPersonalCustomerObjectMetaResponseBody : TeaModel {
        /// <summary>
        /// 是否自定义对象
        /// </summary>
        [NameInMap("customized")]
        [Validation(Required=false)]
        public bool? Customized { get; set; }

        /// <summary>
        /// 字段列表
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFields> Fields { get; set; }
        public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFields : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("customized")]
            [Validation(Required=false)]
            public bool? Customized { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("nillable")]
            [Validation(Required=false)]
            public bool? Nillable { get; set; }

            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("selectOptions")]
            [Validation(Required=false)]
            public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions> SelectOptions { get; set; }
            public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("quote")]
            [Validation(Required=false)]
            public bool? Quote { get; set; }

            [NameInMap("referenceTo")]
            [Validation(Required=false)]
            public string ReferenceTo { get; set; }

            [NameInMap("referenceFields")]
            [Validation(Required=false)]
            public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields> ReferenceFields { get; set; }
            public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields : TeaModel {
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("nillable")]
                [Validation(Required=false)]
                public bool? Nillable { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("selectOptions")]
                [Validation(Required=false)]
                public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions> SelectOptions { get; set; }
                public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("rollUpSummaryFields")]
            [Validation(Required=false)]
            public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields> RollUpSummaryFields { get; set; }
            public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

            }

        }

        /// <summary>
        /// 对象名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
