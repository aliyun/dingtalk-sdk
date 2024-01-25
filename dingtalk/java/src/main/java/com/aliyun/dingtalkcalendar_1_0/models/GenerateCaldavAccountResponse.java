// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GenerateCaldavAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GenerateCaldavAccountResponseBody body;

    public static GenerateCaldavAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        GenerateCaldavAccountResponse self = new GenerateCaldavAccountResponse();
        return TeaModel.build(map, self);
    }

    public GenerateCaldavAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GenerateCaldavAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GenerateCaldavAccountResponse setBody(GenerateCaldavAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public GenerateCaldavAccountResponseBody getBody() {
        return this.body;
    }

}
