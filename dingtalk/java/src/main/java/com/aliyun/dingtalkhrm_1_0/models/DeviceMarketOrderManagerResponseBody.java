// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeviceMarketOrderManagerResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DeviceMarketOrderManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeviceMarketOrderManagerResponseBody self = new DeviceMarketOrderManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public DeviceMarketOrderManagerResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
