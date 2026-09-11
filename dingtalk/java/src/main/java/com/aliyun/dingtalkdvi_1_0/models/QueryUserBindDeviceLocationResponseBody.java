// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBindDeviceLocationResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryUserBindDeviceLocationResponseBodyResult> result;

    public static QueryUserBindDeviceLocationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBindDeviceLocationResponseBody self = new QueryUserBindDeviceLocationResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserBindDeviceLocationResponseBody setResult(java.util.List<QueryUserBindDeviceLocationResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryUserBindDeviceLocationResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryUserBindDeviceLocationResponseBodyResultLatestLocation extends TeaModel {
        @NameInMap("latitude")
        public String latitude;

        @NameInMap("longitude")
        public String longitude;

        @NameInMap("time")
        public Long time;

        public static QueryUserBindDeviceLocationResponseBodyResultLatestLocation build(java.util.Map<String, ?> map) throws Exception {
            QueryUserBindDeviceLocationResponseBodyResultLatestLocation self = new QueryUserBindDeviceLocationResponseBodyResultLatestLocation();
            return TeaModel.build(map, self);
        }

        public QueryUserBindDeviceLocationResponseBodyResultLatestLocation setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public QueryUserBindDeviceLocationResponseBodyResultLatestLocation setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public QueryUserBindDeviceLocationResponseBodyResultLatestLocation setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

    }

    public static class QueryUserBindDeviceLocationResponseBodyResult extends TeaModel {
        @NameInMap("latestLocation")
        public QueryUserBindDeviceLocationResponseBodyResultLatestLocation latestLocation;

        @NameInMap("sn")
        public String sn;

        @NameInMap("userId")
        public String userId;

        public static QueryUserBindDeviceLocationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserBindDeviceLocationResponseBodyResult self = new QueryUserBindDeviceLocationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserBindDeviceLocationResponseBodyResult setLatestLocation(QueryUserBindDeviceLocationResponseBodyResultLatestLocation latestLocation) {
            this.latestLocation = latestLocation;
            return this;
        }
        public QueryUserBindDeviceLocationResponseBodyResultLatestLocation getLatestLocation() {
            return this.latestLocation;
        }

        public QueryUserBindDeviceLocationResponseBodyResult setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public QueryUserBindDeviceLocationResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
