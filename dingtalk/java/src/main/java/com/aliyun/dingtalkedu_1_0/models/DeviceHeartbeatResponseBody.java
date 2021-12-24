// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeviceHeartbeatResponseBody extends TeaModel {
    // 指令
    @NameInMap("code")
    public Integer code;

    public static DeviceHeartbeatResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeviceHeartbeatResponseBody self = new DeviceHeartbeatResponseBody();
        return TeaModel.build(map, self);
    }

    public DeviceHeartbeatResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

}
