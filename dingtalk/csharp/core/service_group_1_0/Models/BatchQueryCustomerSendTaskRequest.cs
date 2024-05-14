// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQueryCustomerSendTaskRequest : TeaModel {
        [NameInMap("gmtCreateEnd")]
        [Validation(Required=false)]
        public string GmtCreateEnd { get; set; }

        [NameInMap("gmtCreateStart")]
        [Validation(Required=false)]
        public string GmtCreateStart { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("needRichStatistics")]
        [Validation(Required=false)]
        public bool? NeedRichStatistics { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("openBatchTaskIds")]
        [Validation(Required=false)]
        public List<string> OpenBatchTaskIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
