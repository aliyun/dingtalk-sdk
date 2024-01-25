// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SubmitMemoryLearningTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitMemoryLearningTaskResponseBody body;

    public static SubmitMemoryLearningTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitMemoryLearningTaskResponse self = new SubmitMemoryLearningTaskResponse();
        return TeaModel.build(map, self);
    }

    public SubmitMemoryLearningTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitMemoryLearningTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitMemoryLearningTaskResponse setBody(SubmitMemoryLearningTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitMemoryLearningTaskResponseBody getBody() {
        return this.body;
    }

}
