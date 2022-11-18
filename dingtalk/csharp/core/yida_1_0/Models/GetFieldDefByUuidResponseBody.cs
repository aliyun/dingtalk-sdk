// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetFieldDefByUuidResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFieldDefByUuidResponseBodyResult> Result { get; set; }
        public class GetFieldDefByUuidResponseBodyResult : TeaModel {
            /// <summary>
            /// 组件展示状态 
            /// 普通NORMAL/禁用DISABLED/只读READONLY/隐藏HIDDEN
            /// </summary>
            [NameInMap("behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            /// <summary>
            /// 子组件信息
            /// </summary>
            [NameInMap("children")]
            [Validation(Required=false)]
            public string Children { get; set; }

            /// <summary>
            /// 组件类型，如文本类型：TextField
            /// </summary>
            [NameInMap("componentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// 字段ID，字段唯一标识
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            /// <summary>
            /// 字段名称。符合国际化标准。
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public object Label { get; set; }

            /// <summary>
            ///  组件属性
            /// </summary>
            [NameInMap("props")]
            [Validation(Required=false)]
            public object Props { get; set; }

        }

        /// <summary>
        /// 是否成功，true代表成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
