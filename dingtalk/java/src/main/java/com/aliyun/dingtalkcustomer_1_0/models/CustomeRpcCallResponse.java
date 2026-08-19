// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class CustomeRpcCallResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomeRpcCallResponseBody body;

    public static CustomeRpcCallResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomeRpcCallResponse self = new CustomeRpcCallResponse();
        return TeaModel.build(map, self);
    }

    public CustomeRpcCallResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomeRpcCallResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomeRpcCallResponse setBody(CustomeRpcCallResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomeRpcCallResponseBody getBody() {
        return this.body;
    }

}
