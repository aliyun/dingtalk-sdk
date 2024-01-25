// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DeviceDingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeviceDingResponseBody body;

    public static DeviceDingResponse build(java.util.Map<String, ?> map) throws Exception {
        DeviceDingResponse self = new DeviceDingResponse();
        return TeaModel.build(map, self);
    }

    public DeviceDingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeviceDingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeviceDingResponse setBody(DeviceDingResponseBody body) {
        this.body = body;
        return this;
    }
    public DeviceDingResponseBody getBody() {
        return this.body;
    }

}
