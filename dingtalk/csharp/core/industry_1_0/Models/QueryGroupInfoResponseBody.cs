// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryGroupInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryGroupInfoResponseBodyContent Content { get; set; }
        public class QueryGroupInfoResponseBodyContent : TeaModel {
            [NameInMap("extendInfos")]
            [Validation(Required=false)]
            public List<QueryGroupInfoResponseBodyContentExtendInfos> ExtendInfos { get; set; }
            public class QueryGroupInfoResponseBodyContentExtendInfos : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28765</para>
                /// </summary>
                [NameInMap("deptCode")]
                [Validation(Required=false)]
                public string DeptCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>科室、医生都不一样</para>
                /// </summary>
                [NameInMap("deptExtendDisplayName")]
                [Validation(Required=false)]
                public string DeptExtendDisplayName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>科室、医生都不一样</para>
                /// </summary>
                [NameInMap("deptExtendKey")]
                [Validation(Required=false)]
                public string DeptExtendKey { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>科室、医生都不一样</para>
                /// </summary>
                [NameInMap("deptExtendValue")]
                [Validation(Required=false)]
                public string DeptExtendValue { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-24 20:30:31</para>
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-24 20:30:31</para>
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("group")]
            [Validation(Required=false)]
            public QueryGroupInfoResponseBodyContentGroup Group { get; set; }
            public class QueryGroupInfoResponseBodyContentGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>321222</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("deptStatus")]
                [Validation(Required=false)]
                public int? DeptStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-08-24 20:30:31</para>
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-08-24 20:30:31</para>
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3212</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("leader")]
                [Validation(Required=false)]
                public QueryGroupInfoResponseBodyContentGroupLeader Leader { get; set; }
                public class QueryGroupInfoResponseBodyContentGroupLeader : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3212</para>
                    /// </summary>
                    [NameInMap("jobNumber")]
                    [Validation(Required=false)]
                    public string JobNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三组</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("parentDeptCode")]
                [Validation(Required=false)]
                public string ParentDeptCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>备注</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

        }

    }

}
