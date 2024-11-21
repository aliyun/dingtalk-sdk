// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryCollegeContactUserDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCollegeContactUserDetailResponseBodyResult Result { get; set; }
        public class QueryCollegeContactUserDetailResponseBodyResult : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("admin")]
            [Validation(Required=false)]
            public bool? Admin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("boss")]
            [Validation(Required=false)]
            public bool? Boss { get; set; }

            [NameInMap("deptIdList")]
            [Validation(Required=false)]
            public List<long?> DeptIdList { get; set; }

            [NameInMap("deptOrderList")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultDeptOrderList> DeptOrderList { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultDeptOrderList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

            }

            [NameInMap("deptPositionSet")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet> DeptPositionSet { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultDeptPositionSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("isMain")]
                [Validation(Required=false)]
                public bool? IsMain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>001</para>
                /// </summary>
                [NameInMap("managerUserId")]
                [Validation(Required=false)]
                public string ManagerUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>学工处处长</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>学工处办公室</para>
                /// </summary>
                [NameInMap("workPlace")]
                [Validation(Required=false)]
                public string WorkPlace { get; set; }

            }

            [NameInMap("deptTypeSet")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet> DeptTypeSet { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultDeptTypeSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>土木202班</para>
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>stru_standard_dept</para>
                /// </summary>
                [NameInMap("deptStructType")]
                [Validation(Required=false)]
                public string DeptStructType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>contact_class_dept</para>
                /// </summary>
                [NameInMap("deptType")]
                [Validation(Required=false)]
                public string DeptType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("structDeptId")]
                [Validation(Required=false)]
                public long? StructDeptId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@xxx.com">test@xxx.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>college_student</para>
            /// </summary>
            [NameInMap("empType")]
            [Validation(Required=false)]
            public string EmpType { get; set; }

            [NameInMap("exclusiveAccount")]
            [Validation(Required=false)]
            public bool? ExclusiveAccount { get; set; }

            [NameInMap("exclusiveAccountCorpId")]
            [Validation(Required=false)]
            public string ExclusiveAccountCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>组织名称</para>
            /// </summary>
            [NameInMap("exclusiveAccountCorpName")]
            [Validation(Required=false)]
            public string ExclusiveAccountCorpName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("exclusiveAccountType")]
            [Validation(Required=false)]
            public string ExclusiveAccountType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;学号&quot;:&quot;12122294&quot;,&quot;在校状态&quot;:&quot;新生&quot;,&quot;学生类别&quot;:&quot;本科生&quot;,&quot;考生号&quot;:&quot;999888&quot;}</para>
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("hideMobile")]
            [Validation(Required=false)]
            public bool? HideMobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1597573616828</para>
            /// </summary>
            [NameInMap("hiredDate")]
            [Validation(Required=false)]
            public long? HiredDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12122294</para>
            /// </summary>
            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("leaderInDept")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultLeaderInDept> LeaderInDept { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultLeaderInDept : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("leader")]
                [Validation(Required=false)]
                public bool? Leader { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12122294</para>
            /// </summary>
            [NameInMap("loginId")]
            [Validation(Required=false)]
            public string LoginId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>studentNo</para>
            /// </summary>
            [NameInMap("loginType")]
            [Validation(Required=false)]
            public string LoginType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("mainDeptId")]
            [Validation(Required=false)]
            public long? MainDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("managerUserid")]
            [Validation(Required=false)]
            public string ManagerUserid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>188****4567</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@xxx.com">test@xxx.com</a></para>
            /// </summary>
            [NameInMap("orgEmail")]
            [Validation(Required=false)]
            public string OrgEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>profession</para>
            /// </summary>
            [NameInMap("orgEmailType")]
            [Validation(Required=false)]
            public string OrgEmailType { get; set; }

            [NameInMap("realAuthed")]
            [Validation(Required=false)]
            public bool? RealAuthed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是一个备注</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("roleList")]
            [Validation(Required=false)]
            public List<QueryCollegeContactUserDetailResponseBodyResultRoleList> RoleList { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultRoleList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>职务</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>宿舍长</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("senior")]
            [Validation(Required=false)]
            public bool? Senior { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>010-86123456-2345</para>
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学工处处长</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("unionEmpExt")]
            [Validation(Required=false)]
            public QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt UnionEmpExt { get; set; }
            public class QueryCollegeContactUserDetailResponseBodyResultUnionEmpExt : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dingxxx</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("unionEmpMapList")]
                [Validation(Required=false)]
                public List<QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList> UnionEmpMapList { get; set; }
                public class QueryCollegeContactUserDetailResponseBodyResultUnionEmpExtUnionEmpMapList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dingxxx</para>
                    /// </summary>
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("userid")]
                    [Validation(Required=false)]
                    public string Userid { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("userid")]
                [Validation(Required=false)]
                public string Userid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>z21HjQliSzpw0YWCNxmii6u2Os62cZ62iSZ</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan666</para>
            /// </summary>
            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学工处办公室</para>
            /// </summary>
            [NameInMap("workPlace")]
            [Validation(Required=false)]
            public string WorkPlace { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
