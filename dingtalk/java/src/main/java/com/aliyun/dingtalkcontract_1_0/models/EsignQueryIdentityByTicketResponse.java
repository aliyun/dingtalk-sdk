// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryIdentityByTicketResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
