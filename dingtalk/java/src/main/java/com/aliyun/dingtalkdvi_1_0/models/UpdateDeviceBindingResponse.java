// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeviceBindingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateDeviceBindingResponseBody body;

    public static UpdateDeviceBindingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeviceBindingResponse self = new UpdateDeviceBindingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateDeviceBindingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateDeviceBindingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateDeviceBindingResponse setBody(UpdateDeviceBindingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateDeviceBindingResponseBody getBody() {
        return this.body;
    }

}
