// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class GetFormInstanceResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFormInstanceResponseBodyResult Result { get; set; }
        public class GetFormInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间。iso8601格式。
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 创建者userid
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 填表code，用此code可调接口获取填表实例列表。
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// 表单内容列表。
            /// </summary>
            [NameInMap("forms")]
            [Validation(Required=false)]
            public List<GetFormInstanceResponseBodyResultForms> Forms { get; set; }
            public class GetFormInstanceResponseBodyResultForms : TeaModel {
                /// <summary>
                /// 表单控件key。
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 表单主题。  当label字段为空或不存在时，忽略这个label和value。
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// 表单的值。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 更新时间。iso8601格式。
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 填表名称。
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 是否成功。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
