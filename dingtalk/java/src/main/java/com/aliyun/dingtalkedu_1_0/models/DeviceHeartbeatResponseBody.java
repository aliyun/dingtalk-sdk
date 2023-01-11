// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeviceHeartbeatResponseBody extends TeaModel {
    /**
     * <p>指令</p>
     */
    @NameInMap("command")
    public Integer command;

    public static DeviceHeartbeatResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeviceHeartbeatResponseBody self = new DeviceHeartbeatResponseBody();
        return TeaModel.build(map, self);
    }

    public DeviceHeartbeatResponseBody setCommand(Integer command) {
        this.command = command;
        return this;
    }
    public Integer getCommand() {
        return this.command;
    }

}
