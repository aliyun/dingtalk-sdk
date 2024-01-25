// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyGetMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public SupplyGetMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyGetMemberResponse setBody(SupplyGetMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyGetMemberResponseBody getBody() {
        return this.body;
    }

}
