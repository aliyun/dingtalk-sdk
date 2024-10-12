// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetFreeTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFreeTaskResponseBody body;

    public static GetFreeTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFreeTaskResponse self = new GetFreeTaskResponse();
        return TeaModel.build(map, self);
    }

    public GetFreeTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFreeTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFreeTaskResponse setBody(GetFreeTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFreeTaskResponseBody getBody() {
        return this.body;
    }

}
