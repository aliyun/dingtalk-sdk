// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeviceMarketManagerResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DeviceMarketManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeviceMarketManagerResponseBody self = new DeviceMarketManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public DeviceMarketManagerResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
