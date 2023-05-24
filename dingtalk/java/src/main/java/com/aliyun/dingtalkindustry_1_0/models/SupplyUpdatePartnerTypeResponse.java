// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdatePartnerTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyUpdatePartnerTypeResponseBody body;

    public static SupplyUpdatePartnerTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdatePartnerTypeResponse self = new SupplyUpdatePartnerTypeResponse();
        return TeaModel.build(map, self);
    }

    public SupplyUpdatePartnerTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyUpdatePartnerTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyUpdatePartnerTypeResponse setBody(SupplyUpdatePartnerTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyUpdatePartnerTypeResponseBody getBody() {
        return this.body;
    }

}
