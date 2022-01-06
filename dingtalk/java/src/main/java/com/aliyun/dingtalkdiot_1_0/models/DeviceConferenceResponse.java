// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DeviceConferenceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeviceConferenceResponseBody body;

    public static DeviceConferenceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeviceConferenceResponse self = new DeviceConferenceResponse();
        return TeaModel.build(map, self);
    }

    public DeviceConferenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeviceConferenceResponse setBody(DeviceConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeviceConferenceResponseBody getBody() {
        return this.body;
    }

}