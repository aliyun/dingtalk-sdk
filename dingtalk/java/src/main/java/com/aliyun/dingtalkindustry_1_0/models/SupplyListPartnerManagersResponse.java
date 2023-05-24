// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerManagersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyListPartnerManagersResponseBody body;

    public static SupplyListPartnerManagersResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerManagersResponse self = new SupplyListPartnerManagersResponse();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerManagersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyListPartnerManagersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyListPartnerManagersResponse setBody(SupplyListPartnerManagersResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyListPartnerManagersResponseBody getBody() {
        return this.body;
    }

}
