// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SupplyAddMemberResponseBody body;

    public static SupplyAddMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddMemberResponse self = new SupplyAddMemberResponse();
        return TeaModel.build(map, self);
    }

    public SupplyAddMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SupplyAddMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SupplyAddMemberResponse setBody(SupplyAddMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public SupplyAddMemberResponseBody getBody() {
        return this.body;
    }

}
