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
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("deviceRoles")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceRoles> DeviceRoles { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceRoles : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

            }

            [NameInMap("deviceScopeType")]
            [Validation(Required=false)]
            public int? DeviceScopeType { get; set; }

            [NameInMap("deviceStaffs")]
            [Validation(Required=false)]
            public List<GetPublicDevicesResponseBodyDataDeviceStaffs> DeviceStaffs { get; set; }
            public class GetPublicDevicesResponseBodyDataDeviceStaffs : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("dataCnt")]
        [Validation(Required=false)]
        public int? DataCnt { get; set; }

        [NameInMap("totalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
