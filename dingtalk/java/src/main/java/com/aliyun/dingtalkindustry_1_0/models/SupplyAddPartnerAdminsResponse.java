// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerAdminsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyAddPartnerAdminsResponseBody body;

    public static SupplyAddPartnerAdminsResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerAdminsResponse self = new SupplyAddPartnerAdminsResponse();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerAdminsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyAddPartnerAdminsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyAddPartnerAdminsResponse setBody(SupplyAddPartnerAdminsResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyAddPartnerAdminsResponseBody getBody() {
        return this.body;
    }

}
