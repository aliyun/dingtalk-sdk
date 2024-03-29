// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeleteRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyDeleteRoleResponseBody body;

    public static SupplyDeleteRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeleteRoleResponse self = new SupplyDeleteRoleResponse();
        return TeaModel.build(map, self);
    }

    public SupplyDeleteRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyDeleteRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyDeleteRoleResponse setBody(SupplyDeleteRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyDeleteRoleResponseBody getBody() {
        return this.body;
    }

}
