// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserFaceStateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetUserFaceStateResponse setBody(GetUserFaceStateResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserFaceStateResponseBody getBody() {
        return this.body;
    }

}
