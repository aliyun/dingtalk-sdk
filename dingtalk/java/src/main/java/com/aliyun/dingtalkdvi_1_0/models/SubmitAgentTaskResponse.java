// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitAgentTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitAgentTaskResponseBody body;

    public static SubmitAgentTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitAgentTaskResponse self = new SubmitAgentTaskResponse();
        return TeaModel.build(map, self);
    }

    public SubmitAgentTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitAgentTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitAgentTaskResponse setBody(SubmitAgentTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitAgentTaskResponseBody getBody() {
        return this.body;
    }

}
