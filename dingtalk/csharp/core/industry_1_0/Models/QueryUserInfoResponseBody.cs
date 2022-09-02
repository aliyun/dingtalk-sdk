// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserInfoResponseBody : TeaModel {
        /// <summary>
        /// 人员详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryUserInfoResponseBodyContent Content { get; set; }
        public class QueryUserInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// comments
            /// </summary>
            [NameInMap("comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// 所在科室
            /// </summary>
            [NameInMap("dept")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentDept> Dept { get; set; }
            public class QueryUserInfoResponseBodyContentDept : TeaModel {
                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// 科室Id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 科室名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 人科关联id
                /// </summary>
                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            /// <summary>
            /// 所在医疗组
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentGroup> Group { get; set; }
            public class QueryUserInfoResponseBodyContentGroup : TeaModel {
                /// <summary>
                /// 医疗组所在科室Id
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// 医疗组所在科室名称
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// 医疗组Id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 医疗组名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            /// <summary>
            /// 职称标签
            /// </summary>
            [NameInMap("job")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJob Job { get; set; }
            public class QueryUserInfoResponseBodyContentJob : TeaModel {
                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            /// <summary>
            /// 工作状态标签, 已废弃, 请使用jobStatusList字段
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJobStatus JobStatus { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatus : TeaModel {
                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// 工作状态标签
            /// </summary>
            [NameInMap("jobStatusList")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentJobStatusList> JobStatusList { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatusList : TeaModel {
                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// 用户Id
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// 人员属性标签
            /// </summary>
            [NameInMap("userProb")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentUserProb UserProb { get; set; }
            public class QueryUserInfoResponseBodyContentUserProb : TeaModel {
                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

        }

    }

}
