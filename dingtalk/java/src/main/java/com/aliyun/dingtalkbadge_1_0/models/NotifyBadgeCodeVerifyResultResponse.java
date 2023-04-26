// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodeVerifyResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public NotifyBadgeCodeVerifyResultResponseBody body;

    public static NotifyBadgeCodeVerifyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodeVerifyResultResponse self = new NotifyBadgeCodeVerifyResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodeVerifyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyBadgeCodeVerifyResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NotifyBadgeCodeVerifyResultResponse setBody(NotifyBadgeCodeVerifyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyBadgeCodeVerifyResultResponseBody getBody() {
        return this.body;
    }

}
