// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetMeCorpSubmissionRequest : TeaModel {
        [NameInMap("appTypes")]
        [Validation(Required=false)]
        public string AppTypes { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("createFromTimeGMT")]
        [Validation(Required=false)]
        public long? CreateFromTimeGMT { get; set; }

        [NameInMap("createToTimeGMT")]
        [Validation(Required=false)]
        public long? CreateToTimeGMT { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("processCodes")]
        [Validation(Required=false)]
        public string ProcessCodes { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
