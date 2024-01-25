// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignInLinkResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSignInLinkResponseBody body;

    public static GetSignInLinkResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignInLinkResponse self = new GetSignInLinkResponse();
        return TeaModel.build(map, self);
    }

    public GetSignInLinkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignInLinkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignInLinkResponse setBody(GetSignInLinkResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignInLinkResponseBody getBody() {
        return this.body;
    }

}
