// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListDeptMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SupplyListDeptMembersResponse setBody(SupplyListDeptMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyListDeptMembersResponseBody getBody() {
        return this.body;
    }

}
