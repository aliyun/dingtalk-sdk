// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainQueryDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyChainQueryDeptInfoResponseBody body;

    public static SupplyChainQueryDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainQueryDeptInfoResponse self = new SupplyChainQueryDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public SupplyChainQueryDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyChainQueryDeptInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyChainQueryDeptInfoResponse setBody(SupplyChainQueryDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyChainQueryDeptInfoResponseBody getBody() {
        return this.body;
    }

}
