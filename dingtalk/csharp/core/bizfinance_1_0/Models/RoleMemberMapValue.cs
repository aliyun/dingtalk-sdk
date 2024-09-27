// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class RoleMemberMapValue : TeaModel {
        [NameInMap("roleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        [NameInMap("memberList")]
        [Validation(Required=false)]
        public List<RoleMemberMapValueMemberList> MemberList { get; set; }
        public class RoleMemberMapValueMemberList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小明</para>
            /// </summary>
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxxx">https://xxxxxxx</a></para>
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

    }

}
