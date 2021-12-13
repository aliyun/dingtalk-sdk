// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class RegisterDeviceResponseBody extends TeaModel {
    // 设备id
    @NameInMap("deviceId")
    public String deviceId;

    public static RegisterDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterDeviceResponseBody self = new RegisterDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterDeviceResponseBody setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

}
