// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// 是否激活
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        [NameInMap("admin")]
        [Validation(Required=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// 是否老板
        /// </summary>
        [NameInMap("boss")]
        [Validation(Required=false)]
        public bool? Boss { get; set; }

        /// <summary>
        /// 所属部门id列表
        /// </summary>
        [NameInMap("departmentIdList")]
        [Validation(Required=false)]
        public List<long?> DepartmentIdList { get; set; }

        /// <summary>
        /// 员工在对应的部门中的排序。
        /// </summary>
        [NameInMap("departmentOrderSet")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyDepartmentOrderSet> DepartmentOrderSet { get; set; }
        public class GetUserResponseBodyDepartmentOrderSet : TeaModel {
            /// <summary>
            /// 下属组织的部门ID
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// 员工在部门中的排序。
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

        }

        /// <summary>
        /// 是否专属帐号
        /// </summary>
        [NameInMap("exclusiveAccount")]
        [Validation(Required=false)]
        public bool? ExclusiveAccount { get; set; }

        /// <summary>
        /// 专属帐号类型：{sso: 企业自定义idp;dingtalk: 钉钉idp}
        /// </summary>
        [NameInMap("exclusiveAccountType")]
        [Validation(Required=false)]
        public string ExclusiveAccountType { get; set; }

        /// <summary>
        /// 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// 入职时间，Unix时间戳，单位ms。
        /// </summary>
        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [NameInMap("jobNumber")]
        [Validation(Required=false)]
        public string JobNumber { get; set; }

        /// <summary>
        /// 员工在对应的部门中是否领导。
        /// </summary>
        [NameInMap("leaderInDepartment")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyLeaderInDepartment> LeaderInDepartment { get; set; }
        public class GetUserResponseBodyLeaderInDepartment : TeaModel {
            /// <summary>
            /// 下属组织的部门ID
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// 员工在对应的部门中是否领导
            /// </summary>
            [NameInMap("leader")]
            [Validation(Required=false)]
            public bool? Leader { get; set; }

        }

        /// <summary>
        /// 主管的ID，仅限企业内部开发调用
        /// </summary>
        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否实名认证
        /// </summary>
        [NameInMap("realAuthed")]
        [Validation(Required=false)]
        public bool? RealAuthed { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyRoleList> RoleList { get; set; }
        public class GetUserResponseBodyRoleList : TeaModel {
            /// <summary>
            /// 角色组名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 角色id
            /// </summary>
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// 是否高管
        /// </summary>
        [NameInMap("senior")]
        [Validation(Required=false)]
        public bool? Senior { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 关联信息
        /// </summary>
        [NameInMap("unionEmpExt")]
        [Validation(Required=false)]
        public GetUserResponseBodyUnionEmpExt UnionEmpExt { get; set; }
        public class GetUserResponseBodyUnionEmpExt : TeaModel {
            /// <summary>
            /// 企业id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            /// <summary>
            /// 关联映射关系
            /// </summary>
            [NameInMap("unionEmpMapList")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> UnionEmpMapList { get; set; }
            public class GetUserResponseBodyUnionEmpExtUnionEmpMapList : TeaModel {
                /// <summary>
                /// 企业 id
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// 员工 id
                /// </summary>
                [NameInMap("staffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

            }

        }

        /// <summary>
        /// 员工在当前开发者企业账号范围内的唯一标识
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 办公地点
        /// </summary>
        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}
