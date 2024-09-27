// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduListUserByFromUserIdsRequest : TeaModel {
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123456</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("guardianUserId")]
        [Validation(Required=false)]
        public string GuardianUserId { get; set; }

    }

}
