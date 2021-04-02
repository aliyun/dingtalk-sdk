// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GenerateCaldavAccountResponseBody : TeaModel {
        [NameInMap("serverAddress")]
        [Validation(Required=false)]
        public string ServerAddress { get; set; }

        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
