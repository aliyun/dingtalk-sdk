// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchGetUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchGetUserResponseBody body;

    public static BatchGetUserResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetUserResponse self = new BatchGetUserResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetUserResponse setBody(BatchGetUserResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetUserResponseBody getBody() {
        return this.body;
    }

}
