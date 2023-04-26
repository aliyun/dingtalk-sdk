// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceListByCorpIdResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryDeviceListByCorpIdResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryDeviceListByCorpIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceListByCorpIdResponseBody self = new QueryDeviceListByCorpIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceListByCorpIdResponseBody setResult(QueryDeviceListByCorpIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryDeviceListByCorpIdResponseBodyResult getResult() {
        return this.result;
    }

    public QueryDeviceListByCorpIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryDeviceListByCorpIdResponseBodyResultList extends TeaModel {
        @NameInMap("appStatus")
        public Integer appStatus;

        @NameInMap("deviceCode")
        public String deviceCode;

        @NameInMap("deviceName")
        public String deviceName;

        public static QueryDeviceListByCorpIdResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceListByCorpIdResponseBodyResultList self = new QueryDeviceListByCorpIdResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryDeviceListByCorpIdResponseBodyResultList setAppStatus(Integer appStatus) {
            this.appStatus = appStatus;
            return this;
        }
        public Integer getAppStatus() {
            return this.appStatus;
        }

        public QueryDeviceListByCorpIdResponseBodyResultList setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public QueryDeviceListByCorpIdResponseBodyResultList setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

    }

    public static class QueryDeviceListByCorpIdResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<QueryDeviceListByCorpIdResponseBodyResultList> list;

        public static QueryDeviceListByCorpIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceListByCorpIdResponseBodyResult self = new QueryDeviceListByCorpIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDeviceListByCorpIdResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryDeviceListByCorpIdResponseBodyResult setList(java.util.List<QueryDeviceListByCorpIdResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<QueryDeviceListByCorpIdResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
