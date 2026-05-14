// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserDeviceLocationResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryUserDeviceLocationResponseBodyResult result;

    public static QueryUserDeviceLocationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserDeviceLocationResponseBody self = new QueryUserDeviceLocationResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserDeviceLocationResponseBody setResult(QueryUserDeviceLocationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserDeviceLocationResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations extends TeaModel {
        @NameInMap("latitude")
        public String latitude;

        @NameInMap("longitude")
        public String longitude;

        @NameInMap("time")
        public String time;

        public static QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations build(java.util.Map<String, ?> map) throws Exception {
            QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations self = new QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations();
            return TeaModel.build(map, self);
        }

        public QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations setTime(String time) {
            this.time = time;
            return this;
        }
        public String getTime() {
            return this.time;
        }

    }

    public static class QueryUserDeviceLocationResponseBodyResultDeviceLocations extends TeaModel {
        @NameInMap("locations")
        public java.util.List<QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations> locations;

        @NameInMap("sn")
        public String sn;

        public static QueryUserDeviceLocationResponseBodyResultDeviceLocations build(java.util.Map<String, ?> map) throws Exception {
            QueryUserDeviceLocationResponseBodyResultDeviceLocations self = new QueryUserDeviceLocationResponseBodyResultDeviceLocations();
            return TeaModel.build(map, self);
        }

        public QueryUserDeviceLocationResponseBodyResultDeviceLocations setLocations(java.util.List<QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations> locations) {
            this.locations = locations;
            return this;
        }
        public java.util.List<QueryUserDeviceLocationResponseBodyResultDeviceLocationsLocations> getLocations() {
            return this.locations;
        }

        public QueryUserDeviceLocationResponseBodyResultDeviceLocations setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

    }

    public static class QueryUserDeviceLocationResponseBodyResult extends TeaModel {
        @NameInMap("deviceLocations")
        public java.util.List<QueryUserDeviceLocationResponseBodyResultDeviceLocations> deviceLocations;

        public static QueryUserDeviceLocationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserDeviceLocationResponseBodyResult self = new QueryUserDeviceLocationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserDeviceLocationResponseBodyResult setDeviceLocations(java.util.List<QueryUserDeviceLocationResponseBodyResultDeviceLocations> deviceLocations) {
            this.deviceLocations = deviceLocations;
            return this;
        }
        public java.util.List<QueryUserDeviceLocationResponseBodyResultDeviceLocations> getDeviceLocations() {
            return this.deviceLocations;
        }

    }

}
