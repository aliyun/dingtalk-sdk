// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateShortcutResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dentry</para>
        /// </summary>
        [NameInMap("openDentryInfo")]
        [Validation(Required=false)]
        public CreateShortcutResponseBodyOpenDentryInfo OpenDentryInfo { get; set; }
        public class CreateShortcutResponseBodyOpenDentryInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dentryUuid</para>
            /// </summary>
            [NameInMap("dentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>driveDentryId</para>
            /// </summary>
            [NameInMap("driveDentryId")]
            [Validation(Required=false)]
            public string DriveDentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>driveSpaceId</para>
            /// </summary>
            [NameInMap("driveSpaceId")]
            [Validation(Required=false)]
            public string DriveSpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>docx</para>
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spaceInfo</para>
            /// </summary>
            [NameInMap("spaceInfo")]
            [Validation(Required=false)]
            public CreateShortcutResponseBodyOpenDentryInfoSpaceInfo SpaceInfo { get; set; }
            public class CreateShortcutResponseBodyOpenDentryInfoSpaceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>im</para>
                /// </summary>
                [NameInMap("sceneType")]
                [Validation(Required=false)]
                public string SceneType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
