// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryIdentityByTicketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EsignQueryIdentityByTicketResponseBody body;

    public static EsignQueryIdentityByTicketResponse build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryIdentityByTicketResponse self = new EsignQueryIdentityByTicketResponse();
        return TeaModel.build(map, self);
    }

    public EsignQueryIdentityByTicketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EsignQueryIdentityByTicketResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EsignQueryIdentityByTicketResponse setBody(EsignQueryIdentityByTicketResponseBody body) {
        this.body = body;
        return this;
    }
    public EsignQueryIdentityByTicketResponseBody getBody() {
        return this.body;
    }

}
