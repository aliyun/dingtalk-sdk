// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddCustomSignConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCustomSignConfigResponseBody body;

    public static AddCustomSignConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCustomSignConfigResponse self = new AddCustomSignConfigResponse();
        return TeaModel.build(map, self);
    }

    public AddCustomSignConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCustomSignConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCustomSignConfigResponse setBody(AddCustomSignConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCustomSignConfigResponseBody getBody() {
        return this.body;
    }

}
