// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GenerateDarkWaterMarkResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GenerateDarkWaterMarkResponseBody body;

    public static GenerateDarkWaterMarkResponse build(java.util.Map<String, ?> map) throws Exception {
        GenerateDarkWaterMarkResponse self = new GenerateDarkWaterMarkResponse();
        return TeaModel.build(map, self);
    }

    public GenerateDarkWaterMarkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GenerateDarkWaterMarkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GenerateDarkWaterMarkResponse setBody(GenerateDarkWaterMarkResponseBody body) {
        this.body = body;
        return this;
    }
    public GenerateDarkWaterMarkResponseBody getBody() {
        return this.body;
    }

}
