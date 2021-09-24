// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodeRefundResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public NotifyBadgeCodeRefundResultResponseBody body;

    public static NotifyBadgeCodeRefundResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodeRefundResultResponse self = new NotifyBadgeCodeRefundResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodeRefundResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyBadgeCodeRefundResultResponse setBody(NotifyBadgeCodeRefundResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyBadgeCodeRefundResultResponseBody getBody() {
        return this.body;
    }

}
