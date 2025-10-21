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
            [NameInMap("deviceDepts")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceDepts> DeviceDepts { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceDepts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试部门</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("deviceRoles")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceRoles> DeviceRoles { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceRoles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>测试角色</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deviceScopeType")]
            [Validation(Required=false)]
            public int? DeviceScopeType { get; set; }

            [NameInMap("deviceStaffs")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceStaffs> DeviceStaffs { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceStaffs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("deviceUuid")]
            [Validation(Required=false)]
            public string DeviceUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1671767361000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1671767361000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88:66:5a:07:2b:04</para>
            /// </summary>
            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mac</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retryPermission")]
            [Validation(Required=false)]
            public string RetryPermission { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("dataCnt")]
        [Validation(Required=false)]
        public int? DataCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
