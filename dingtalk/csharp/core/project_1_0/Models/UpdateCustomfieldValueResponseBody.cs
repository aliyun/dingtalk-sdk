// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueResponseBody : TeaModel {
        /// <summary>
        /// 返回对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateCustomfieldValueResponseBodyResult Result { get; set; }
        public class UpdateCustomfieldValueResponseBodyResult : TeaModel {
            /// <summary>
            /// 自定义字段数组
            /// </summary>
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<UpdateCustomfieldValueResponseBodyResultCustomfields> Customfields { get; set; }
            public class UpdateCustomfieldValueResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// 自定义字段id
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                /// <summary>
                /// 自定义字段值对象
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public List<UpdateCustomfieldValueResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class UpdateCustomfieldValueResponseBodyResultCustomfieldsValue : TeaModel {
                    /// <summary>
                    /// 自定义字段显示值
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

    }

}
