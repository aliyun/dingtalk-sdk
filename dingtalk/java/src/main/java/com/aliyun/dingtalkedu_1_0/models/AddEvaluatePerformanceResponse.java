// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddEvaluatePerformanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddEvaluatePerformanceResponseBody body;

    public static AddEvaluatePerformanceResponse build(java.util.Map<String, ?> map) throws Exception {
        AddEvaluatePerformanceResponse self = new AddEvaluatePerformanceResponse();
        return TeaModel.build(map, self);
    }

    public AddEvaluatePerformanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddEvaluatePerformanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddEvaluatePerformanceResponse setBody(AddEvaluatePerformanceResponseBody body) {
        this.body = body;
        return this;
    }
    public AddEvaluatePerformanceResponseBody getBody() {
        return this.body;
    }

}
