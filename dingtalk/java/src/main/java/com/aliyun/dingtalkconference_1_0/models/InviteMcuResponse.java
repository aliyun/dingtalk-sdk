// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class InviteMcuResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InviteMcuResponseBody body;

    public static InviteMcuResponse build(java.util.Map<String, ?> map) throws Exception {
        InviteMcuResponse self = new InviteMcuResponse();
        return TeaModel.build(map, self);
    }

    public InviteMcuResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InviteMcuResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InviteMcuResponse setBody(InviteMcuResponseBody body) {
        this.body = body;
        return this;
    }
    public InviteMcuResponseBody getBody() {
        return this.body;
    }

}
