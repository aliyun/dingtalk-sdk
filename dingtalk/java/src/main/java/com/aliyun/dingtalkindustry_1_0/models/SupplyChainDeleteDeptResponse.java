// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainDeleteDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyChainDeleteDeptResponseBody body;

    public static SupplyChainDeleteDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainDeleteDeptResponse self = new SupplyChainDeleteDeptResponse();
        return TeaModel.build(map, self);
    }

    public SupplyChainDeleteDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyChainDeleteDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyChainDeleteDeptResponse setBody(SupplyChainDeleteDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyChainDeleteDeptResponseBody getBody() {
        return this.body;
    }

}
