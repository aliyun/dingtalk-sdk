// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeNotifyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateBadgeNotifyResponse setBody(CreateBadgeNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBadgeNotifyResponseBody getBody() {
        return this.body;
    }

}
