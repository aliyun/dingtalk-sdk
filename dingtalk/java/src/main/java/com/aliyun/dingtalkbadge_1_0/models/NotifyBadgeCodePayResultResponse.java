// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodePayResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public NotifyBadgeCodePayResultResponseBody body;

    public static NotifyBadgeCodePayResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodePayResultResponse self = new NotifyBadgeCodePayResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodePayResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyBadgeCodePayResultResponse setBody(NotifyBadgeCodePayResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyBadgeCodePayResultResponseBody getBody() {
        return this.body;
    }

}
