// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetUploadInfoRequest : TeaModel {
        [NameInMap("addConflictPolicy")]
        [Validation(Required=false)]
        public string AddConflictPolicy { get; set; }

        [NameInMap("callerRegion")]
        [Validation(Required=false)]
        public string CallerRegion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("withInternalEndPoint")]
        [Validation(Required=false)]
        public bool? WithInternalEndPoint { get; set; }

        [NameInMap("withRegion")]
        [Validation(Required=false)]
        public bool? WithRegion { get; set; }

    }

}
