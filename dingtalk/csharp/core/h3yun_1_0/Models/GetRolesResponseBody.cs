// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRolesResponseBodyData Data { get; set; }
        public class GetRolesResponseBodyData : TeaModel {
            [NameInMap("roleGroups")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoleGroups> RoleGroups { get; set; }
            public class GetRolesResponseBodyDataRoleGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>18f923a7-5a5e-426d-94ae-a55ad1a4b240</para>
                /// </summary>
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这是一个游客体验组</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>261befb8-728d-4b79-a0b4-7b6ddfb3f94e</para>
                /// </summary>
                [NameInMap("groupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>261befb8-728d-4b79-a0b4-7b6ddfb3f94e</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>游客体验组</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<GetRolesResponseBodyDataRoles> Roles { get; set; }
            public class GetRolesResponseBodyDataRoles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>18f923a7-5a5e-426d-94ae-a55ad1a4b240</para>
                /// </summary>
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这是一个游客体验角色</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>261befb8-728d-4b79-a0b4-7b6ddfb3f94e</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88cfc4a2-22ba-48e2-bc5e-8d475ce49d38</para>
                /// </summary>
                [NameInMap("roleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>085b47cf-ab7b-417f-bb7a-b5ee3b32de16</para>
                /// </summary>
                [NameInMap("roleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>游客体验角色</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
