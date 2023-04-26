// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateRangeProtectionRequest : TeaModel {
        [NameInMap("editableSetting")]
        [Validation(Required=false)]
        public CreateRangeProtectionRequestEditableSetting EditableSetting { get; set; }
        public class CreateRangeProtectionRequestEditableSetting : TeaModel {
            [NameInMap("deleteColumns")]
            [Validation(Required=false)]
            public bool? DeleteColumns { get; set; }

            [NameInMap("deleteRows")]
            [Validation(Required=false)]
            public bool? DeleteRows { get; set; }

            [NameInMap("editCells")]
            [Validation(Required=false)]
            public bool? EditCells { get; set; }

            [NameInMap("formatCells")]
            [Validation(Required=false)]
            public bool? FormatCells { get; set; }

            [NameInMap("insertColumns")]
            [Validation(Required=false)]
            public bool? InsertColumns { get; set; }

            [NameInMap("insertRows")]
            [Validation(Required=false)]
            public bool? InsertRows { get; set; }

            [NameInMap("toggleColumnsVisibility")]
            [Validation(Required=false)]
            public bool? ToggleColumnsVisibility { get; set; }

            [NameInMap("toggleRowsVisibility")]
            [Validation(Required=false)]
            public bool? ToggleRowsVisibility { get; set; }

        }

        [NameInMap("otherUserPermission")]
        [Validation(Required=false)]
        public string OtherUserPermission { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
