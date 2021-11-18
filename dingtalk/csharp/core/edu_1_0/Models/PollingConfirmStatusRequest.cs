// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PollingConfirmStatusRequest : TeaModel {
        /// <summary>
        /// courseCode
        /// </summary>
        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// ext
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// isvCode
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
