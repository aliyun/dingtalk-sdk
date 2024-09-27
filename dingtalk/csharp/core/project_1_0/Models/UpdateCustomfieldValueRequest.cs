// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>62a010c153c2ef52xxxx</para>
        /// </summary>
        [NameInMap("customFieldId")]
        [Validation(Required=false)]
        public string CustomFieldId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>自定义字段-文本</para>
        /// </summary>
        [NameInMap("customFieldName")]
        [Validation(Required=false)]
        public string CustomFieldName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<UpdateCustomfieldValueRequestValue> Value { get; set; }
        public class UpdateCustomfieldValueRequestValue : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>我是具体显示值</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
