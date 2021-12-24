// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeviceHeartbeatResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeviceHeartbeatResponseBody body;

    public static DeviceHeartbeatResponse build(java.util.Map<String, ?> map) throws Exception {
        DeviceHeartbeatResponse self = new DeviceHeartbeatResponse();
        return TeaModel.build(map, self);
    }

    public DeviceHeartbeatResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeviceHeartbeatResponse setBody(DeviceHeartbeatResponseBody body) {
        this.body = body;
        return this;
    }
    public DeviceHeartbeatResponseBody getBody() {
        return this.body;
    }

}
