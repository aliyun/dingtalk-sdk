// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BatchGetTaskResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchGetTaskResultResponseBody body;

    public static BatchGetTaskResultResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetTaskResultResponse self = new BatchGetTaskResultResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetTaskResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetTaskResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetTaskResultResponse setBody(BatchGetTaskResultResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetTaskResultResponseBody getBody() {
        return this.body;
    }

}
