// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class CreateOrgHonorRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("avatarFrameMediaId")]
        [Validation(Required=false)]
        public string AvatarFrameMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("defaultBgColor")]
        [Validation(Required=false)]
        public string DefaultBgColor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("medalDesc")]
        [Validation(Required=false)]
        public string MedalDesc { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("medalMediaId")]
        [Validation(Required=false)]
        public string MedalMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("medalName")]
        [Validation(Required=false)]
        public string MedalName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
