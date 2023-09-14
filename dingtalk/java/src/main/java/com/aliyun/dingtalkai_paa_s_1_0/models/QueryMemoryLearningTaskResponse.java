// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryMemoryLearningTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryMemoryLearningTaskResponseBody body;

    public static QueryMemoryLearningTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMemoryLearningTaskResponse self = new QueryMemoryLearningTaskResponse();
        return TeaModel.build(map, self);
    }

    public QueryMemoryLearningTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMemoryLearningTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMemoryLearningTaskResponse setBody(QueryMemoryLearningTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMemoryLearningTaskResponseBody getBody() {
        return this.body;
    }

}
