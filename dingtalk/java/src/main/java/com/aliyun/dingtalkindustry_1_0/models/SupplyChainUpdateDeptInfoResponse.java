// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainUpdateDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyChainUpdateDeptInfoResponseBody body;

    public static SupplyChainUpdateDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainUpdateDeptInfoResponse self = new SupplyChainUpdateDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public SupplyChainUpdateDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyChainUpdateDeptInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyChainUpdateDeptInfoResponse setBody(SupplyChainUpdateDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyChainUpdateDeptInfoResponseBody getBody() {
        return this.body;
    }

}
