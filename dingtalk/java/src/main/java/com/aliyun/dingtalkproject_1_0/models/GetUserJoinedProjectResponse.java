// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserJoinedProjectResponseBody body;

    public static GetUserJoinedProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserJoinedProjectResponse self = new GetUserJoinedProjectResponse();
        return TeaModel.build(map, self);
    }

    public GetUserJoinedProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserJoinedProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserJoinedProjectResponse setBody(GetUserJoinedProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserJoinedProjectResponseBody getBody() {
        return this.body;
    }

}
