// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAuthUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAuthUrlResponseBody body;

    public static GetAuthUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAuthUrlResponse self = new GetAuthUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetAuthUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAuthUrlResponse setBody(GetAuthUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAuthUrlResponseBody getBody() {
        return this.body;
    }

}
