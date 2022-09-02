// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormInstancesResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFormInstancesResponseBodyResult Result { get; set; }
        public class ListFormInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否还有下一页数据。
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 填表实例列表。
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListFormInstancesResponseBodyResultList> List { get; set; }
            public class ListFormInstancesResponseBodyResultList : TeaModel {
                /// <summary>
                /// 创建时间。iso8601格式。
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 填表code，用此code可调接口获取填表列表。
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// 实例ID。
                /// </summary>
                [NameInMap("formInstanceId")]
                [Validation(Required=false)]
                public string FormInstanceId { get; set; }

                /// <summary>
                /// 表单内容列表。
                /// </summary>
                [NameInMap("forms")]
                [Validation(Required=false)]
                public List<ListFormInstancesResponseBodyResultListForms> Forms { get; set; }
                public class ListFormInstancesResponseBodyResultListForms : TeaModel {
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
                /// 学生班级ID。
                /// </summary>
                [NameInMap("studentClassId")]
                [Validation(Required=false)]
                public string StudentClassId { get; set; }

                /// <summary>
                /// 学生班级名称。
                /// </summary>
                [NameInMap("studentClassName")]
                [Validation(Required=false)]
                public string StudentClassName { get; set; }

                /// <summary>
                /// 学生名称。
                /// </summary>
                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                /// <summary>
                /// 学生ID。
                /// </summary>
                [NameInMap("studentUserId")]
                [Validation(Required=false)]
                public string StudentUserId { get; set; }

                /// <summary>
                /// 提交人的userid。
                /// </summary>
                [NameInMap("submitterUserId")]
                [Validation(Required=false)]
                public string SubmitterUserId { get; set; }

                /// <summary>
                /// 提交人姓名。
                /// </summary>
                [NameInMap("submitterUserName")]
                [Validation(Required=false)]
                public string SubmitterUserName { get; set; }

                /// <summary>
                /// 填表名称。
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// 下一次分页offset的值。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
