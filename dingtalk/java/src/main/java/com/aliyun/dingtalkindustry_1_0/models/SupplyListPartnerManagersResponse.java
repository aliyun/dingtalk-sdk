// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerManagersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
