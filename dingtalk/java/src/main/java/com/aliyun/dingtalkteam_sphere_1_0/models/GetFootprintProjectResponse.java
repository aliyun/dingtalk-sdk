// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetFootprintProjectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFootprintProjectResponseBody body;

    public static GetFootprintProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFootprintProjectResponse self = new GetFootprintProjectResponse();
        return TeaModel.build(map, self);
    }

    public GetFootprintProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFootprintProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFootprintProjectResponse setBody(GetFootprintProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFootprintProjectResponseBody getBody() {
        return this.body;
    }

}
