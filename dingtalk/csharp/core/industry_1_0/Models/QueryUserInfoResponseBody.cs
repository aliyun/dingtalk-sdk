// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryUserInfoResponseBodyContent Content { get; set; }
        public class QueryUserInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comments</para>
            /// </summary>
            [NameInMap("comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dept")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentDept> Dept { get; set; }
            public class QueryUserInfoResponseBodyContentDept : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-06-02 17:44:17</para>
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-06-02 17:44:17</para>
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>科室名称2</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentGroup> Group { get; set; }
            public class QueryUserInfoResponseBodyContentGroup : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>科室名称2</para>
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-06-02 17:44:17</para>
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-06-02 17:44:17</para>
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>医疗组名称2</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("job")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJob Job { get; set; }
            public class QueryUserInfoResponseBodyContentJob : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分类</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code1</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>展示名称</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0001</para>
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJobStatus JobStatus { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatus : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分类</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标签Code</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>展示名称</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("jobStatusList")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentJobStatusList> JobStatusList { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatusList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分类</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标签Code</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>展示名称</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u0398812938821</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户名称</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userProb")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentUserProb UserProb { get; set; }
            public class QueryUserInfoResponseBodyContentUserProb : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分类</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标签Code</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>展示名称</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

        }

    }

}
