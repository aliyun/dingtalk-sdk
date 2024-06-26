// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetAsyncTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// 
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// 
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("failed")]
        [Validation(Required=false)]
        public int? Failed { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public int? Success { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
