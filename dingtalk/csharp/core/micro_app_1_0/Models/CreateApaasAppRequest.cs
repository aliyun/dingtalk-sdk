// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class CreateApaasAppRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appDesc")]
        [Validation(Required=false)]
        public string AppDesc { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appIcon")]
        [Validation(Required=false)]
        public string AppIcon { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizAppId")]
        [Validation(Required=false)]
        public string BizAppId { get; set; }

        [NameInMap("homepageEditLink")]
        [Validation(Required=false)]
        public string HomepageEditLink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("homepageLink")]
        [Validation(Required=false)]
        public string HomepageLink { get; set; }

        [NameInMap("isShortCut")]
        [Validation(Required=false)]
        public int? IsShortCut { get; set; }

        [NameInMap("ompLink")]
        [Validation(Required=false)]
        public string OmpLink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pcHomepageEditLink")]
        [Validation(Required=false)]
        public string PcHomepageEditLink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pcHomepageLink")]
        [Validation(Required=false)]
        public string PcHomepageLink { get; set; }

        [NameInMap("templateKey")]
        [Validation(Required=false)]
        public string TemplateKey { get; set; }

    }

}
