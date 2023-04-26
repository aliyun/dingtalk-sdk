// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignInListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetSignInListResponseBody body;

    public static GetSignInListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignInListResponse self = new GetSignInListResponse();
        return TeaModel.build(map, self);
    }

    public GetSignInListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignInListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignInListResponse setBody(GetSignInListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignInListResponseBody getBody() {
        return this.body;
    }

}
