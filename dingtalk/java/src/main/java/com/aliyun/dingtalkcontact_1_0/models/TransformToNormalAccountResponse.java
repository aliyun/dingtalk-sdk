// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TransformToNormalAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TransformToNormalAccountResponseBody body;

    public static TransformToNormalAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        TransformToNormalAccountResponse self = new TransformToNormalAccountResponse();
        return TeaModel.build(map, self);
    }

    public TransformToNormalAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TransformToNormalAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TransformToNormalAccountResponse setBody(TransformToNormalAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public TransformToNormalAccountResponseBody getBody() {
        return this.body;
    }

}
