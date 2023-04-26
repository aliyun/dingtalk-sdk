// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class DecodeBadgeCodeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DecodeBadgeCodeResponseBody body;

    public static DecodeBadgeCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        DecodeBadgeCodeResponse self = new DecodeBadgeCodeResponse();
        return TeaModel.build(map, self);
    }

    public DecodeBadgeCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DecodeBadgeCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DecodeBadgeCodeResponse setBody(DecodeBadgeCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public DecodeBadgeCodeResponseBody getBody() {
        return this.body;
    }

}
