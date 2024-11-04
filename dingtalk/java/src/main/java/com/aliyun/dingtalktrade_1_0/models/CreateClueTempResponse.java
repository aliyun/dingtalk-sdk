// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateClueTempResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateClueTempResponseBody body;

    public static CreateClueTempResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateClueTempResponse self = new CreateClueTempResponse();
        return TeaModel.build(map, self);
    }

    public CreateClueTempResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateClueTempResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateClueTempResponse setBody(CreateClueTempResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateClueTempResponseBody getBody() {
        return this.body;
    }

}
