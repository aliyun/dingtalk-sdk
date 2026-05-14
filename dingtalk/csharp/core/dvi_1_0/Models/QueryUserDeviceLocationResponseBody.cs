// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryUserDeviceLocationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserDeviceLocationResponseBodyResult Result { get; set; }
        public class QueryUserDeviceLocationResponseBodyResult : TeaModel {
            [NameInMap("deviceLocations")]
            [Validation(Required=false)]
            public List<QueryUserDeviceLocationResponseBodyResultDeviceLocations> DeviceLocations { get; set; }
            public class QueryUserDeviceLocationResponseBodyResultDeviceLocations : TeaModel {
                [NameInMap("locations")]
                [Validation(Required=false)]
                public List<QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations> Locations { get; set; }
                public class QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations : TeaModel {
                    [NameInMap("latitude")]
                    [Validation(Required=false)]
                    public string Latitude { get; set; }

                    [NameInMap("longitude")]
                    [Validation(Required=false)]
                    public string Longitude { get; set; }

                    [NameInMap("time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

            }

        }

    }

}
