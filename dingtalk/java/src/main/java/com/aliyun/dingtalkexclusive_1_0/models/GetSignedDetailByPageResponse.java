// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSignedDetailByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetSignedDetailByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignedDetailByPageResponse setBody(GetSignedDetailByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignedDetailByPageResponseBody getBody() {
        return this.body;
    }

}
