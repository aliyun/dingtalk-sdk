// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RefreshWebOfficeTokenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RefreshWebOfficeTokenResponseBody body;

    public static RefreshWebOfficeTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        RefreshWebOfficeTokenResponse self = new RefreshWebOfficeTokenResponse();
        return TeaModel.build(map, self);
    }

    public RefreshWebOfficeTokenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RefreshWebOfficeTokenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RefreshWebOfficeTokenResponse setBody(RefreshWebOfficeTokenResponseBody body) {
        this.body = body;
        return this;
    }
    public RefreshWebOfficeTokenResponseBody getBody() {
        return this.body;
    }

}
