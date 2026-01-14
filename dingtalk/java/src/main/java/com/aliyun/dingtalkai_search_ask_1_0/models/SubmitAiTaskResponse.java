// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitAiTaskResponseBody body;

    public static SubmitAiTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiTaskResponse self = new SubmitAiTaskResponse();
        return TeaModel.build(map, self);
    }

    public SubmitAiTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitAiTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitAiTaskResponse setBody(SubmitAiTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitAiTaskResponseBody getBody() {
        return this.body;
    }

}
