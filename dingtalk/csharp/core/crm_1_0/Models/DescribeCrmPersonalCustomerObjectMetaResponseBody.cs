// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class DescribeCrmPersonalCustomerObjectMetaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC-XXXX</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("customized")]
        [Validation(Required=false)]
        public bool? Customized { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFields> Fields { get; set; }
        public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFields : TeaModel {
            [NameInMap("customized")]
            [Validation(Required=false)]
            public bool? Customized { get; set; }

            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nillable")]
            [Validation(Required=false)]
            public bool? Nillable { get; set; }

            [NameInMap("quote")]
            [Validation(Required=false)]
            public bool? Quote { get; set; }

            [NameInMap("referenceFields")]
            [Validation(Required=false)]
            public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields> ReferenceFields { get; set; }
            public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields : TeaModel {
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nillable")]
                [Validation(Required=false)]
                public bool? Nillable { get; set; }

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

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            [NameInMap("referenceTo")]
            [Validation(Required=false)]
            public string ReferenceTo { get; set; }

            [NameInMap("rollUpSummaryFields")]
            [Validation(Required=false)]
            public List<DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields> RollUpSummaryFields { get; set; }
            public class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
