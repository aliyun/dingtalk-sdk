// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RegisterDeviceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>manager1,1000,10001</para>
        /// </summary>
        [NameInMap("collaborators")]
        [Validation(Required=false)]
        public string Collaborators { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>生产组1号设备负责生产第一批产品</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key_xxxxxxx</para>
        /// </summary>
        [NameInMap("deviceKey")]
        [Validation(Required=false)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生产1组1号机</para>
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager1,manager2</para>
        /// </summary>
        [NameInMap("managers")]
        [Validation(Required=false)]
        public string Managers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager10</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
