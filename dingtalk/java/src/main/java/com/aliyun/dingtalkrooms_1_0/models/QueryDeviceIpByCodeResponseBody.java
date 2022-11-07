// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceIpByCodeResponseBody extends TeaModel {
    // 结果
    @NameInMap("result")
    public QueryDeviceIpByCodeResponseBodyResult result;

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

    public static class QueryDeviceIpByCodeResponseBodyResult extends TeaModel {
        // 设备内网ip
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
