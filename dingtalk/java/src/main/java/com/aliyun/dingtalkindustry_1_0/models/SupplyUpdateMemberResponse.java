// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdateMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyUpdateMemberResponseBody body;

    public static SupplyUpdateMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdateMemberResponse self = new SupplyUpdateMemberResponse();
        return TeaModel.build(map, self);
    }

    public SupplyUpdateMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyUpdateMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyUpdateMemberResponse setBody(SupplyUpdateMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyUpdateMemberResponseBody getBody() {
        return this.body;
    }

}
