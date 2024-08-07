// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateVirusScanTaskRequest : TeaModel {
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("fileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
