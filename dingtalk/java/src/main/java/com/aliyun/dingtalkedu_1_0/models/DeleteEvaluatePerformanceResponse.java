// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteEvaluatePerformanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteEvaluatePerformanceResponseBody body;

    public static DeleteEvaluatePerformanceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteEvaluatePerformanceResponse self = new DeleteEvaluatePerformanceResponse();
        return TeaModel.build(map, self);
    }

    public DeleteEvaluatePerformanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteEvaluatePerformanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteEvaluatePerformanceResponse setBody(DeleteEvaluatePerformanceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteEvaluatePerformanceResponseBody getBody() {
        return this.body;
    }

}
