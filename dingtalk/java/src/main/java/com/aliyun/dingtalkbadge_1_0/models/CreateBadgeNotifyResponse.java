// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeNotifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateBadgeNotifyResponseBody body;

    public static CreateBadgeNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeNotifyResponse self = new CreateBadgeNotifyResponse();
        return TeaModel.build(map, self);
    }

    public CreateBadgeNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateBadgeNotifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateBadgeNotifyResponse setBody(CreateBadgeNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBadgeNotifyResponseBody getBody() {
        return this.body;
    }

}
