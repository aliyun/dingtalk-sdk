// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyGetMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SupplyGetMemberResponseBody body;

    public static SupplyGetMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyGetMemberResponse self = new SupplyGetMemberResponse();
        return TeaModel.build(map, self);
    }

    public SupplyGetMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyGetMemberResponse setBody(SupplyGetMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyGetMemberResponseBody getBody() {
        return this.body;
    }

}
