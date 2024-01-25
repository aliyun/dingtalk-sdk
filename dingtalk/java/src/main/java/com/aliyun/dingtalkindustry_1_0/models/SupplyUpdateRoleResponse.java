// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdateRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyUpdateRoleResponseBody body;

    public static SupplyUpdateRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdateRoleResponse self = new SupplyUpdateRoleResponse();
        return TeaModel.build(map, self);
    }

    public SupplyUpdateRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyUpdateRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyUpdateRoleResponse setBody(SupplyUpdateRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyUpdateRoleResponseBody getBody() {
        return this.body;
    }

}
