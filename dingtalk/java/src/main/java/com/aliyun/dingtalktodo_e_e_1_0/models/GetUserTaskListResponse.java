// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetUserTaskListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserTaskListResponseBody body;

    public static GetUserTaskListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserTaskListResponse self = new GetUserTaskListResponse();
        return TeaModel.build(map, self);
    }

    public GetUserTaskListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserTaskListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserTaskListResponse setBody(GetUserTaskListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserTaskListResponseBody getBody() {
        return this.body;
    }

}
