// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateCoupleGroupRequest : TeaModel {
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

        [NameInMap("users")]
        [Validation(Required=false)]
        public List<CreateCoupleGroupRequestUsers> Users { get; set; }
        public class CreateCoupleGroupRequestUsers : TeaModel {
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
