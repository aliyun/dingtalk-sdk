// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListDeptMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyListDeptMembersResponseBody body;

    public static SupplyListDeptMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyListDeptMembersResponse self = new SupplyListDeptMembersResponse();
        return TeaModel.build(map, self);
    }

    public SupplyListDeptMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyListDeptMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyListDeptMembersResponse setBody(SupplyListDeptMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyListDeptMembersResponseBody getBody() {
        return this.body;
    }

}
