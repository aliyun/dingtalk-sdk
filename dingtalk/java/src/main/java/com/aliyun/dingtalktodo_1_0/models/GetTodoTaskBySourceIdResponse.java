// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskBySourceIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTodoTaskBySourceIdResponseBody body;

    public static GetTodoTaskBySourceIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskBySourceIdResponse self = new GetTodoTaskBySourceIdResponse();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskBySourceIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTodoTaskBySourceIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTodoTaskBySourceIdResponse setBody(GetTodoTaskBySourceIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTodoTaskBySourceIdResponseBody getBody() {
        return this.body;
    }

}
