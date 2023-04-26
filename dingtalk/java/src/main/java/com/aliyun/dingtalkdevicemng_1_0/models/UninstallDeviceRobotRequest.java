// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UninstallDeviceRobotRequest extends TeaModel {
    @NameInMap("deviceCode")
    public String deviceCode;

    @NameInMap("uuid")
    public String uuid;

    public static UninstallDeviceRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        UninstallDeviceRobotRequest self = new UninstallDeviceRobotRequest();
        return TeaModel.build(map, self);
    }

    public UninstallDeviceRobotRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public UninstallDeviceRobotRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
