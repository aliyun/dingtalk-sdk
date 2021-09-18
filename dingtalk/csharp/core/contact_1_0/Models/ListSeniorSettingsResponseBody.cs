// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListSeniorSettingsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("seniorStaffId")]
        [Validation(Required=false)]
        public string SeniorStaffId { get; set; }

        [NameInMap("protectScenes")]
        [Validation(Required=false)]
        public List<string> ProtectScenes { get; set; }

        [NameInMap("seniorWhiteList")]
        [Validation(Required=false)]
        public List<ListSeniorSettingsResponseBodySeniorWhiteList> SeniorWhiteList { get; set; }
        public class ListSeniorSettingsResponseBodySeniorWhiteList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
