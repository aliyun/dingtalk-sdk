// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskInvolvemembersRequest : TeaModel {
        [NameInMap("addInvolvers")]
        [Validation(Required=false)]
        public List<string> AddInvolvers { get; set; }

        [NameInMap("delInvolvers")]
        [Validation(Required=false)]
        public List<string> DelInvolvers { get; set; }

        [NameInMap("involveMembers")]
        [Validation(Required=false)]
        public List<string> InvolveMembers { get; set; }

    }

}
