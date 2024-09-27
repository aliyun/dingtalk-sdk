// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryDepartmentInfoResponseBodyContent Content { get; set; }
        public class QueryDepartmentInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("department")]
            [Validation(Required=false)]
            public QueryDepartmentInfoResponseBodyContentDepartment Department { get; set; }
            public class QueryDepartmentInfoResponseBodyContentDepartment : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2341</para>
                /// </summary>
                [NameInMap("deptCode")]
                [Validation(Required=false)]
                public string DeptCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>血液科</para>
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("deptOrder")]
                [Validation(Required=false)]
                public long? DeptOrder { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("deptStatus")]
                [Validation(Required=false)]
                public int? DeptStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("deptType")]
                [Validation(Required=false)]
                public int? DeptType { get; set; }

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
                /// <b>Example:</b>
                /// <para>12321</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>血液科</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3421</para>
                /// </summary>
                [NameInMap("parentDeptCode")]
                [Validation(Required=false)]
                public string ParentDeptCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>科室</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("wardIdList")]
                [Validation(Required=false)]
                public List<long?> WardIdList { get; set; }

            }

            [NameInMap("extendInfos")]
            [Validation(Required=false)]
            public List<QueryDepartmentInfoResponseBodyContentExtendInfos> ExtendInfos { get; set; }
            public class QueryDepartmentInfoResponseBodyContentExtendInfos : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("deptCode")]
                [Validation(Required=false)]
                public string DeptCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>科室主任</para>
                /// </summary>
                [NameInMap("deptExtendDisplayName")]
                [Validation(Required=false)]
                public string DeptExtendDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("deptExtendKey")]
                [Validation(Required=false)]
                public string DeptExtendKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

    }

}
