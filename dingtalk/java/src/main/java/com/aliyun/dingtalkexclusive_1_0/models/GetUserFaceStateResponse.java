// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserFaceStateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserFaceStateResponseBody body;

    public static GetUserFaceStateResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserFaceStateResponse self = new GetUserFaceStateResponse();
        return TeaModel.build(map, self);
    }

    public GetUserFaceStateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserFaceStateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserFaceStateResponse setBody(GetUserFaceStateResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserFaceStateResponseBody getBody() {
        return this.body;
    }

}
