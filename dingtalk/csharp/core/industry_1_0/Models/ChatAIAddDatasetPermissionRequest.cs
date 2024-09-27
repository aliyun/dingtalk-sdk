// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatAIAddDatasetPermissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("authorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        [NameInMap("authorizedObjectId")]
        [Validation(Required=false)]
        public List<string> AuthorizedObjectId { get; set; }

        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>操作人id</para>
        /// </summary>
        [NameInMap("optUser")]
        [Validation(Required=false)]
        public string OptUser { get; set; }

    }

}
