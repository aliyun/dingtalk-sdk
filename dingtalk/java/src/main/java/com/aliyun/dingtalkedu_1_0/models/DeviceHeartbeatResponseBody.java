// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeviceHeartbeatResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0心跳正常，1增量更新，2上传日志，3全量更新</p>
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
