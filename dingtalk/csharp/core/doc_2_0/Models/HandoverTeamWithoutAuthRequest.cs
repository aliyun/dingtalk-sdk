// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class HandoverTeamWithoutAuthRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public HandoverTeamWithoutAuthRequestParam Param { get; set; }
        public class HandoverTeamWithoutAuthRequestParam : TeaModel {
            [NameInMap("leave")]
            [Validation(Required=false)]
            public bool? Leave { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("newOwner")]
            [Validation(Required=false)]
            public string NewOwner { get; set; }

            [NameInMap("notify")]
            [Validation(Required=false)]
            public bool? Notify { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("teamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

        }

    }

}
