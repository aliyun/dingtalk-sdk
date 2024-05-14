// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class PushDingMessageRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("messageUrl")]
        [Validation(Required=false)]
        public string MessageUrl { get; set; }

        [NameInMap("pictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

        [NameInMap("singleTitle")]
        [Validation(Required=false)]
        public string SingleTitle { get; set; }

        [NameInMap("singleUrl")]
        [Validation(Required=false)]
        public string SingleUrl { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
