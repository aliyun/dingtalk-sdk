// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class InitMultipartFileUploadResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DINGTALK</para>
        /// </summary>
        [NameInMap("storageDriver")]
        [Validation(Required=false)]
        public string StorageDriver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>upload_key</para>
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}
