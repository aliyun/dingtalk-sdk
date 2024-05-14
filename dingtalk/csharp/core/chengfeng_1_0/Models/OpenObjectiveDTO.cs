// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenObjectiveDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("executor")]
        [Validation(Required=false)]
        public OpenUserDTO Executor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("keyResults")]
        [Validation(Required=false)]
        public List<OpenKeyResultDTO> KeyResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public OpenPeriodDTO Period { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("teams")]
        [Validation(Required=false)]
        public List<OpenTeamDTO> Teams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
