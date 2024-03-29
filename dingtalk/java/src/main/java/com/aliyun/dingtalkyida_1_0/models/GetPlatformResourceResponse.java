// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPlatformResourceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetPlatformResourceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPlatformResourceResponse setBody(GetPlatformResourceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPlatformResourceResponseBody getBody() {
        return this.body;
    }

}
