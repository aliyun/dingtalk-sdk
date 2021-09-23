// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPlatformResourceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetPlatformResourceResponseBody body;

    public static GetPlatformResourceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPlatformResourceResponse self = new GetPlatformResourceResponse();
        return TeaModel.build(map, self);
    }

    public GetPlatformResourceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPlatformResourceResponse setBody(GetPlatformResourceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPlatformResourceResponseBody getBody() {
        return this.body;
    }

}
