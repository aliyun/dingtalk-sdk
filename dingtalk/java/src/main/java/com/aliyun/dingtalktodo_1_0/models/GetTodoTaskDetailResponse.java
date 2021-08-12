// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTodoTaskDetailResponseBody body;

    public static GetTodoTaskDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskDetailResponse self = new GetTodoTaskDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTodoTaskDetailResponse setBody(GetTodoTaskDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTodoTaskDetailResponseBody getBody() {
        return this.body;
    }

}
