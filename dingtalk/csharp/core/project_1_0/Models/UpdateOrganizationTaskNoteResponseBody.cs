// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskNoteResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskNoteResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskNoteResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>我是一条备注哦</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-13T05:48:45.788Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
