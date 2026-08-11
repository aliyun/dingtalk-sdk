// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class AnalyzeSubjectTransactionRiskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contractId")]
        [Validation(Required=false)]
        public long? ContractId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("historyEndTime")]
        [Validation(Required=false)]
        public long? HistoryEndTime { get; set; }

        [NameInMap("historyStartTime")]
        [Validation(Required=false)]
        public long? HistoryStartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subjectUniqueCode")]
        [Validation(Required=false)]
        public string SubjectUniqueCode { get; set; }

    }

}
