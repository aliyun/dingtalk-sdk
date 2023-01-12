// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPublicDevicesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetPublicDevicesResponseBodyData> Data { get; set; }
        public class GetPublicDevicesResponseBodyData : TeaModel {
            /// <summary>
            /// 部门列表，仅生效范围是部分生效时有效
            /// </summary>
            [NameInMap("deviceDepts")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceDepts> DeviceDepts { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceDepts : TeaModel {
                /// <summary>
                /// 部门id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 部门名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 角色列表，仅生效范围是部分生效时有效
            /// </summary>
            [NameInMap("deviceRoles")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceRoles> DeviceRoles { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceRoles : TeaModel {
                /// <summary>
                /// 角色名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 角色code
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

            }

            /// <summary>
            /// 生效范围
            /// </summary>
            [NameInMap("deviceScopeType")]
            [Validation(Required=false)]
            public int? DeviceScopeType { get; set; }

            /// <summary>
            /// 员工列表，仅生效范围是部分生效时有效
            /// </summary>
            [NameInMap("deviceStaffs")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceStaffs> DeviceStaffs { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceStaffs : TeaModel {
                /// <summary>
                /// 员工姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 员工id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 创建时间时间戳
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 修改时间时间戳
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 设备mac地址
            /// </summary>
            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            /// <summary>
            /// 系统
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// 设备标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 当前页条目数
        /// </summary>
        [NameInMap("dataCnt")]
        [Validation(Required=false)]
        public int? DataCnt { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [NameInMap("totalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
