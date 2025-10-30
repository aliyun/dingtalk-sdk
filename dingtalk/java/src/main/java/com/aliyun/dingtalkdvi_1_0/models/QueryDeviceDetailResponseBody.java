// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryDeviceDetailResponseBodyResult> result;

    public static QueryDeviceDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceDetailResponseBody self = new QueryDeviceDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceDetailResponseBody setResult(java.util.List<QueryDeviceDetailResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryDeviceDetailResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryDeviceDetailResponseBodyResult extends TeaModel {
        @NameInMap("bindTimestamp")
        public Long bindTimestamp;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("sn")
        public String sn;

        @NameInMap("userId")
        public String userId;

        public static QueryDeviceDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceDetailResponseBodyResult self = new QueryDeviceDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDeviceDetailResponseBodyResult setBindTimestamp(Long bindTimestamp) {
            this.bindTimestamp = bindTimestamp;
            return this;
        }
        public Long getBindTimestamp() {
            return this.bindTimestamp;
        }

        public QueryDeviceDetailResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public QueryDeviceDetailResponseBodyResult setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public QueryDeviceDetailResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
