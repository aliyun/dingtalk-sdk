// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateAgentTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateAgentTaskResponseBody body;

    public static UpdateAgentTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateAgentTaskResponse self = new UpdateAgentTaskResponse();
        return TeaModel.build(map, self);
    }

    public UpdateAgentTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateAgentTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateAgentTaskResponse setBody(UpdateAgentTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateAgentTaskResponseBody getBody() {
        return this.body;
    }

}
