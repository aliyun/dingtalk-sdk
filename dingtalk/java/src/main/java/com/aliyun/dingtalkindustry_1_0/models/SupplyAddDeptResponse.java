// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyAddDeptResponseBody body;

    public static SupplyAddDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddDeptResponse self = new SupplyAddDeptResponse();
        return TeaModel.build(map, self);
    }

    public SupplyAddDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyAddDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyAddDeptResponse setBody(SupplyAddDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyAddDeptResponseBody getBody() {
        return this.body;
    }

}
