// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DecodePayCodeResponseBody body;

    public static DecodePayCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        DecodePayCodeResponse self = new DecodePayCodeResponse();
        return TeaModel.build(map, self);
    }

    public DecodePayCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DecodePayCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DecodePayCodeResponse setBody(DecodePayCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public DecodePayCodeResponseBody getBody() {
        return this.body;
    }

}
