// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class CreateNoteForIsvRequest : TeaModel {
        [NameInMap("contactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contactPhoneNum")]
        [Validation(Required=false)]
        public string ContactPhoneNum { get; set; }

        [NameInMap("contactTitle")]
        [Validation(Required=false)]
        public string ContactTitle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("inputPhoneNum")]
        [Validation(Required=false)]
        public string InputPhoneNum { get; set; }

    }

}
