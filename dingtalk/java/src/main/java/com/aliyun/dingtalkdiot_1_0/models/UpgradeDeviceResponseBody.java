// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class UpgradeDeviceResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static UpgradeDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpgradeDeviceResponseBody self = new UpgradeDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpgradeDeviceResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
