// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetAgentTasksResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAgentTasksResponseBody body;

    public static GetAgentTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAgentTasksResponse self = new GetAgentTasksResponse();
        return TeaModel.build(map, self);
    }

    public GetAgentTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAgentTasksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAgentTasksResponse setBody(GetAgentTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAgentTasksResponseBody getBody() {
        return this.body;
    }

}
