// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerAdminsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyDeletePartnerAdminsResponseBody body;

    public static SupplyDeletePartnerAdminsResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerAdminsResponse self = new SupplyDeletePartnerAdminsResponse();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerAdminsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyDeletePartnerAdminsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyDeletePartnerAdminsResponse setBody(SupplyDeletePartnerAdminsResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyDeletePartnerAdminsResponseBody getBody() {
        return this.body;
    }

}
