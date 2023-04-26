// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenObjectiveDTO : TeaModel {
        [NameInMap("executor")]
        [Validation(Required=false)]
        public OpenUserDTO Executor { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("keyResults")]
        [Validation(Required=false)]
        public List<OpenKeyResultDTO> KeyResults { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public OpenPeriodDTO Period { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("teams")]
        [Validation(Required=false)]
        public List<OpenTeamDTO> Teams { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
