// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class KickMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public KickMembersResponseBody body;

    public static KickMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        KickMembersResponse self = new KickMembersResponse();
        return TeaModel.build(map, self);
    }

    public KickMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public KickMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public KickMembersResponse setBody(KickMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public KickMembersResponseBody getBody() {
        return this.body;
    }

}
