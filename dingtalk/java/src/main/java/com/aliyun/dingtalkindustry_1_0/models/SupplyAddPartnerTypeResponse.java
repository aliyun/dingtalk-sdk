// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyAddPartnerTypeResponseBody body;

    public static SupplyAddPartnerTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerTypeResponse self = new SupplyAddPartnerTypeResponse();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyAddPartnerTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyAddPartnerTypeResponse setBody(SupplyAddPartnerTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyAddPartnerTypeResponseBody getBody() {
        return this.body;
    }

}
