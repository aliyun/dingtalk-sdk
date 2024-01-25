// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryUserResponseBody body;

    public static BatchQueryUserResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryUserResponse self = new BatchQueryUserResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryUserResponse setBody(BatchQueryUserResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryUserResponseBody getBody() {
        return this.body;
    }

}
