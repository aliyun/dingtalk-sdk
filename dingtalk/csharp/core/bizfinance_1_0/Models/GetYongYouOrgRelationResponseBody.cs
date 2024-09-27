// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetYongYouOrgRelationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20230731</para>
        /// </summary>
        [NameInMap("chanjetCorpId")]
        [Validation(Required=false)]
        public string ChanjetCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01162352501424064728</para>
        /// </summary>
        [NameInMap("chanjetUserId")]
        [Validation(Required=false)]
        public string ChanjetUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding9f50b15bccd16741</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01162352501424064728</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
