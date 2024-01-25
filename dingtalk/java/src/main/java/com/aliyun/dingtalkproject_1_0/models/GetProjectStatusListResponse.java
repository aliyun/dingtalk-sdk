// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectStatusListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProjectStatusListResponseBody body;

    public static GetProjectStatusListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProjectStatusListResponse self = new GetProjectStatusListResponse();
        return TeaModel.build(map, self);
    }

    public GetProjectStatusListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProjectStatusListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProjectStatusListResponse setBody(GetProjectStatusListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectStatusListResponseBody getBody() {
        return this.body;
    }

}
