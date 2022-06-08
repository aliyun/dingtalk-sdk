// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UninstallDeviceRobotRequest extends TeaModel {
    // 设备编码，客户侧生成的设备标识，能够唯一标识一个设备，该字段与deviceUuid字段需要二选一，并且不能都填充。
    @NameInMap("deviceCode")
    public String deviceCode;

    // 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCode字段需要二选一，并且不能都填充。
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
