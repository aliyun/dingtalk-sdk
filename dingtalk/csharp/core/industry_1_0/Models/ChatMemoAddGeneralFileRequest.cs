// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoAddGeneralFileRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("fileDesc")]
        [Validation(Required=false)]
        public string FileDesc { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("tagList")]
        [Validation(Required=false)]
        public List<ChatMemoAddGeneralFileRequestTagList> TagList { get; set; }
        public class ChatMemoAddGeneralFileRequestTagList : TeaModel {
            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            [NameInMap("tagValueList")]
            [Validation(Required=false)]
            public List<string> TagValueList { get; set; }

        }

    }

}
