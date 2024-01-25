// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class AddCallConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCallConfigResponseBody body;

    public static AddCallConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCallConfigResponse self = new AddCallConfigResponse();
        return TeaModel.build(map, self);
    }

    public AddCallConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCallConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCallConfigResponse setBody(AddCallConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCallConfigResponseBody getBody() {
        return this.body;
    }

}
