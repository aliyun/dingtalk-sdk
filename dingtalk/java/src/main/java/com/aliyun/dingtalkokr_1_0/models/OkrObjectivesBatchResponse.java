// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrObjectivesBatchResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public OkrObjectivesBatchResponseBody body;

    public static OkrObjectivesBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        OkrObjectivesBatchResponse self = new OkrObjectivesBatchResponse();
        return TeaModel.build(map, self);
    }

    public OkrObjectivesBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OkrObjectivesBatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OkrObjectivesBatchResponse setBody(OkrObjectivesBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public OkrObjectivesBatchResponseBody getBody() {
        return this.body;
    }

}
