// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyun_shu_1_0.Models
{
    public class SaveOpenExternalLogRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("logSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("logType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openExt")]
        [Validation(Required=false)]
        public string OpenExt { get; set; }

    }

}
