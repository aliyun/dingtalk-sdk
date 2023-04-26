// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateInviteUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateInviteUrlResponseBody body;

    public static CreateInviteUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateInviteUrlResponse self = new CreateInviteUrlResponse();
        return TeaModel.build(map, self);
    }

    public CreateInviteUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateInviteUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateInviteUrlResponse setBody(CreateInviteUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateInviteUrlResponseBody getBody() {
        return this.body;
    }

}
