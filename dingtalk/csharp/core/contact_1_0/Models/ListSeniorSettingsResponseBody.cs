// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListSeniorSettingsResponseBody : TeaModel {
        [NameInMap("protectScenes")]
        [Validation(Required=false)]
        public List<string> ProtectScenes { get; set; }

        [NameInMap("seniorStaffId")]
        [Validation(Required=false)]
        public string SeniorStaffId { get; set; }

        [NameInMap("seniorWhiteList")]
        [Validation(Required=false)]
        public List<ListSeniorSettingsResponseBodySeniorWhiteList> SeniorWhiteList { get; set; }
        public class ListSeniorSettingsResponseBodySeniorWhiteList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试角色</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
