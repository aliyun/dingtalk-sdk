// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleSchemaGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleSchemaGetResponseBody body;

    public static AISaleSchemaGetResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleSchemaGetResponse self = new AISaleSchemaGetResponse();
        return TeaModel.build(map, self);
    }

    public AISaleSchemaGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleSchemaGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleSchemaGetResponse setBody(AISaleSchemaGetResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleSchemaGetResponseBody getBody() {
        return this.body;
    }

}
