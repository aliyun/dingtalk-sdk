// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetApplicationAuthorizationServicePlatformResourceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetApplicationAuthorizationServicePlatformResourceResponseBody body;

    public static GetApplicationAuthorizationServicePlatformResourceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetApplicationAuthorizationServicePlatformResourceResponse self = new GetApplicationAuthorizationServicePlatformResourceResponse();
        return TeaModel.build(map, self);
    }

    public GetApplicationAuthorizationServicePlatformResourceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetApplicationAuthorizationServicePlatformResourceResponse setBody(GetApplicationAuthorizationServicePlatformResourceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetApplicationAuthorizationServicePlatformResourceResponseBody getBody() {
        return this.body;
    }

}
