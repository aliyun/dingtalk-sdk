// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyDeletePartnerTypeResponseBody body;

    public static SupplyDeletePartnerTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerTypeResponse self = new SupplyDeletePartnerTypeResponse();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyDeletePartnerTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyDeletePartnerTypeResponse setBody(SupplyDeletePartnerTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyDeletePartnerTypeResponseBody getBody() {
        return this.body;
    }

}
