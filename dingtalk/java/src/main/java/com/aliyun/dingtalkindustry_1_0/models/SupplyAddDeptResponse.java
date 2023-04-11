// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SupplyAddDeptResponse setBody(SupplyAddDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyAddDeptResponseBody getBody() {
        return this.body;
    }

}
