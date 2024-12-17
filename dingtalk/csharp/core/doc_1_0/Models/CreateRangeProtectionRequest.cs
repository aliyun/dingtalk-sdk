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

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<CreateRangeProtectionRequestMembers> Members { get; set; }
        public class CreateRangeProtectionRequestMembers : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public string MemberType { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("otherUserPermission")]
        [Validation(Required=false)]
        public string OtherUserPermission { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppgAQuHfOoNVpJiStDwWCEgiEiE</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
