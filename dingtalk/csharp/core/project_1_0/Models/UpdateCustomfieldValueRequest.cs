// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueRequest : TeaModel {
        /// <summary>
        /// 自定义字段id
        /// </summary>
        [NameInMap("customfieldId")]
        [Validation(Required=false)]
        public string CustomfieldId { get; set; }

        /// <summary>
        /// 自定义字段名
        /// </summary>
        [NameInMap("customfieldName")]
        [Validation(Required=false)]
        public string CustomfieldName { get; set; }

        /// <summary>
        /// 自定义字段值列表，最多10个
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<UpdateCustomfieldValueRequestValue> Value { get; set; }
        public class UpdateCustomfieldValueRequestValue : TeaModel {
            /// <summary>
            /// 自定义字段显示值
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
