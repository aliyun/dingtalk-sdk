// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddPartnerManagersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyAddPartnerManagersResponseBody body;

    public static SupplyAddPartnerManagersResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddPartnerManagersResponse self = new SupplyAddPartnerManagersResponse();
        return TeaModel.build(map, self);
    }

    public SupplyAddPartnerManagersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyAddPartnerManagersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyAddPartnerManagersResponse setBody(SupplyAddPartnerManagersResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyAddPartnerManagersResponseBody getBody() {
        return this.body;
    }

}
