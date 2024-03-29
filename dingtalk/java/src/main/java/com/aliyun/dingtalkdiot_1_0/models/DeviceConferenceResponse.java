// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DeviceConferenceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public DeviceConferenceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeviceConferenceResponse setBody(DeviceConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeviceConferenceResponseBody getBody() {
        return this.body;
    }

}
