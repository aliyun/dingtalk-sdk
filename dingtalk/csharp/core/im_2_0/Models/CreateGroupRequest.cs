// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http://***.png</para>
        /// </summary>
        [NameInMap("groupAvatar")]
        [Validation(Required=false)]
        public string GroupAvatar { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户群</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8d42****nkld</para>
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1745****8777</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<CreateGroupRequestUsers> Users { get; set; }
        public class CreateGroupRequestUsers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1107****2120</para>
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public bool? GroupOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1745****8778</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
