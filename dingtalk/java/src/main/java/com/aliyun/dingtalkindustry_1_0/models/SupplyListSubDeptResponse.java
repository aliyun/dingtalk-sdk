// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListSubDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyListSubDeptResponseBody body;

    public static SupplyListSubDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyListSubDeptResponse self = new SupplyListSubDeptResponse();
        return TeaModel.build(map, self);
    }

    public SupplyListSubDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyListSubDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyListSubDeptResponse setBody(SupplyListSubDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyListSubDeptResponseBody getBody() {
        return this.body;
    }

}
