// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class LogoutRequest extends TeaModel {
    @NameInMap("deviceType")
    public String deviceType;

    @NameInMap("userId")
    public String userId;

    public static LogoutRequest build(java.util.Map<String, ?> map) throws Exception {
        LogoutRequest self = new LogoutRequest();
        return TeaModel.build(map, self);
    }

    public LogoutRequest setDeviceType(String deviceType) {
        this.deviceType = deviceType;
        return this;
    }
    public String getDeviceType() {
        return this.deviceType;
    }

    public LogoutRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
