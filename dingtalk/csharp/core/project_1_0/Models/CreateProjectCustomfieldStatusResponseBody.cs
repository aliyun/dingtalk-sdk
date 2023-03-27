// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusResponseBody : TeaModel {
        /// <summary>
        /// 结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectCustomfieldStatusResponseBodyResult Result { get; set; }
        public class CreateProjectCustomfieldStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// 高级字段类型名(冗余)。
            /// </summary>
            [NameInMap("advCfObjectType")]
            [Validation(Required=false)]
            public string AdvCfObjectType { get; set; }

            /// <summary>
            /// 自定义字段ID。
            /// </summary>
            [NameInMap("customfieldId")]
            [Validation(Required=false)]
            public string CustomfieldId { get; set; }

            /// <summary>
            /// 字段名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 如果是企业字段，返回企业字段ID。
            /// </summary>
            [NameInMap("originalId")]
            [Validation(Required=false)]
            public string OriginalId { get; set; }

            /// <summary>
            /// 字段类型。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 字段值集合。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public List<CreateProjectCustomfieldStatusResponseBodyResultValue> Value { get; set; }
            public class CreateProjectCustomfieldStatusResponseBodyResultValue : TeaModel {
                /// <summary>
                /// 字段值id。
                /// </summary>
                [NameInMap("fieldvalueId")]
                [Validation(Required=false)]
                public string FieldvalueId { get; set; }

                /// <summary>
                /// 自定义字段值元属性。
                /// </summary>
                [NameInMap("metaString")]
                [Validation(Required=false)]
                public string MetaString { get; set; }

                /// <summary>
                /// 自定义字段值。
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
