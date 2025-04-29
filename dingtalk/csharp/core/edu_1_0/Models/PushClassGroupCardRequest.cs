// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PushClassGroupCardRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        [NameInMap("groupTypeList")]
        [Validation(Required=false)]
        public List<string> GroupTypeList { get; set; }

        [NameInMap("privateCardData")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> PrivateCardData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("publicCardData")]
        [Validation(Required=false)]
        public Dictionary<string, string> PublicCardData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("studentUserIds")]
        [Validation(Required=false)]
        public List<string> StudentUserIds { get; set; }

    }

}
