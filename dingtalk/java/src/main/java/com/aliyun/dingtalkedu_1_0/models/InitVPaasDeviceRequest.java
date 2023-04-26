// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitVPaasDeviceRequest extends TeaModel {
    @NameInMap("sn")
    public String sn;

    @NameInMap("timestamp")
    public Long timestamp;

    @NameInMap("type")
    public String type;

    public static InitVPaasDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        InitVPaasDeviceRequest self = new InitVPaasDeviceRequest();
        return TeaModel.build(map, self);
    }

    public InitVPaasDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public InitVPaasDeviceRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public InitVPaasDeviceRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
