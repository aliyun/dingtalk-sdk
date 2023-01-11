// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceIpByCodeResponseBody extends TeaModel {
    /**
     * <p>结果</p>
     */
    @NameInMap("result")
    public QueryDeviceIpByCodeResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryDeviceIpByCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceIpByCodeResponseBody self = new QueryDeviceIpByCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceIpByCodeResponseBody setResult(QueryDeviceIpByCodeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryDeviceIpByCodeResponseBodyResult getResult() {
        return this.result;
    }

    public QueryDeviceIpByCodeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryDeviceIpByCodeResponseBodyResult extends TeaModel {
        /**
         * <p>设备内网ip</p>
         */
        @NameInMap("deviceIp")
        public String deviceIp;

        public static QueryDeviceIpByCodeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceIpByCodeResponseBodyResult self = new QueryDeviceIpByCodeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDeviceIpByCodeResponseBodyResult setDeviceIp(String deviceIp) {
            this.deviceIp = deviceIp;
            return this;
        }
        public String getDeviceIp() {
            return this.deviceIp;
        }

    }

}
