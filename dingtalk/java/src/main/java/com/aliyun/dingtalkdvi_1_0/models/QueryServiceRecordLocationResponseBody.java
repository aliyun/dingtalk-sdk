// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordLocationResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryServiceRecordLocationResponseBodyResult> result;

    public static QueryServiceRecordLocationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordLocationResponseBody self = new QueryServiceRecordLocationResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordLocationResponseBody setResult(java.util.List<QueryServiceRecordLocationResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryServiceRecordLocationResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryServiceRecordLocationResponseBodyResultLocations extends TeaModel {
        @NameInMap("latitude")
        public String latitude;

        @NameInMap("longitude")
        public String longitude;

        @NameInMap("time")
        public Long time;

        public static QueryServiceRecordLocationResponseBodyResultLocations build(java.util.Map<String, ?> map) throws Exception {
            QueryServiceRecordLocationResponseBodyResultLocations self = new QueryServiceRecordLocationResponseBodyResultLocations();
            return TeaModel.build(map, self);
        }

        public QueryServiceRecordLocationResponseBodyResultLocations setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public QueryServiceRecordLocationResponseBodyResultLocations setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public QueryServiceRecordLocationResponseBodyResultLocations setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

    }

    public static class QueryServiceRecordLocationResponseBodyResult extends TeaModel {
        @NameInMap("locations")
        public java.util.List<QueryServiceRecordLocationResponseBodyResultLocations> locations;

        @NameInMap("recordId")
        public String recordId;

        public static QueryServiceRecordLocationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryServiceRecordLocationResponseBodyResult self = new QueryServiceRecordLocationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryServiceRecordLocationResponseBodyResult setLocations(java.util.List<QueryServiceRecordLocationResponseBodyResultLocations> locations) {
            this.locations = locations;
            return this;
        }
        public java.util.List<QueryServiceRecordLocationResponseBodyResultLocations> getLocations() {
            return this.locations;
        }

        public QueryServiceRecordLocationResponseBodyResult setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

    }

}
