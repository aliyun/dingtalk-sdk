// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class SyncDataRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("etlTime")]
        [Validation(Required=false)]
        public string EtlTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

    }

}
