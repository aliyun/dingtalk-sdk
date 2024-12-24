// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetStaredProjectsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetStaredProjectsResponseBody body;

    public static GetStaredProjectsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetStaredProjectsResponse self = new GetStaredProjectsResponse();
        return TeaModel.build(map, self);
    }

    public GetStaredProjectsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetStaredProjectsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetStaredProjectsResponse setBody(GetStaredProjectsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetStaredProjectsResponseBody getBody() {
        return this.body;
    }

}
