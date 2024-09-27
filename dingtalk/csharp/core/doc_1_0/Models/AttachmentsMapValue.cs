// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class AttachmentsMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>upload_key</para>
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>media_type</para>
        /// </summary>
        [NameInMap("mediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
