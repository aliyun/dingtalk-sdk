// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RegisterDeviceRequest : TeaModel {
        [NameInMap("collaborators")]
        [Validation(Required=false)]
        public string Collaborators { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceKey")]
        [Validation(Required=false)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("managers")]
        [Validation(Required=false)]
        public string Managers { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
