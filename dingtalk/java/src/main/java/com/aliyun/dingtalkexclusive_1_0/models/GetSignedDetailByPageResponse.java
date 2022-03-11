// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSignedDetailByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSignedDetailByPageResponseBody body;

    public static GetSignedDetailByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignedDetailByPageResponse self = new GetSignedDetailByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetSignedDetailByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignedDetailByPageResponse setBody(GetSignedDetailByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignedDetailByPageResponseBody getBody() {
        return this.body;
    }

}
