// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeleteMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyDeleteMemberResponseBody body;

    public static SupplyDeleteMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeleteMemberResponse self = new SupplyDeleteMemberResponse();
        return TeaModel.build(map, self);
    }

    public SupplyDeleteMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyDeleteMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyDeleteMemberResponse setBody(SupplyDeleteMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyDeleteMemberResponseBody getBody() {
        return this.body;
    }

}
