// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeviceHeartbeatRequest extends TeaModel {
    // 设备序列号
    @NameInMap("sn")
    public String sn;

    public static DeviceHeartbeatRequest build(java.util.Map<String, ?> map) throws Exception {
        DeviceHeartbeatRequest self = new DeviceHeartbeatRequest();
        return TeaModel.build(map, self);
    }

    public DeviceHeartbeatRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
