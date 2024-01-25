// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeletePartnerManagersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyDeletePartnerManagersResponseBody body;

    public static SupplyDeletePartnerManagersResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeletePartnerManagersResponse self = new SupplyDeletePartnerManagersResponse();
        return TeaModel.build(map, self);
    }

    public SupplyDeletePartnerManagersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyDeletePartnerManagersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyDeletePartnerManagersResponse setBody(SupplyDeletePartnerManagersResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyDeletePartnerManagersResponseBody getBody() {
        return this.body;
    }

}
