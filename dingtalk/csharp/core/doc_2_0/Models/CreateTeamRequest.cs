// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateTeamRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1***.png">https://img.alicdn.com/imgextra/i1/O1***.png</a></para>
        /// </summary>
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是小组的介绍</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1***.png">https://img.alicdn.com/imgextra/i1/O1***.png</a></para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateTeamRequestMembers> Members { get; set; }
        public class CreateTeamRequestMembers : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEp3JcM******UIbhwiE</para>
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试小组名称</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YEp3JcM******UIbhwiE</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("teamType")]
        [Validation(Required=false)]
        public int? TeamType { get; set; }

    }

}
