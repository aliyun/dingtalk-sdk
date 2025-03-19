// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class CreateMailFolderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("extensions")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extensions { get; set; }

        [NameInMap("folerId")]
        [Validation(Required=false)]
        public string FolerId { get; set; }

    }

}
