// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetInstancesByIdsResponseBody : TeaModel {
        [NameInMap("customFormInstanceResponseList")]
        [Validation(Required=false)]
        public List<GetInstancesByIdsResponseBodyCustomFormInstanceResponseList> CustomFormInstanceResponseList { get; set; }
        public class GetInstancesByIdsResponseBodyCustomFormInstanceResponseList : TeaModel {
            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public string Fields { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("modifiedUnionId")]
            [Validation(Required=false)]
            public string ModifiedUnionId { get; set; }

            [NameInMap("openDataInstanceId")]
            [Validation(Required=false)]
            public string OpenDataInstanceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("openTeamId")]
            [Validation(Required=false)]
            public string OpenTeamId { get; set; }

            [NameInMap("ownerUnionId")]
            [Validation(Required=false)]
            public string OwnerUnionId { get; set; }

        }

    }

}
