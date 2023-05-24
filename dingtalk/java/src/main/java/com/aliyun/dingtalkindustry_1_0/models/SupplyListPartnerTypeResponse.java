// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyListPartnerTypeResponseBody body;

    public static SupplyListPartnerTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerTypeResponse self = new SupplyListPartnerTypeResponse();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyListPartnerTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyListPartnerTypeResponse setBody(SupplyListPartnerTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyListPartnerTypeResponseBody getBody() {
        return this.body;
    }

}
