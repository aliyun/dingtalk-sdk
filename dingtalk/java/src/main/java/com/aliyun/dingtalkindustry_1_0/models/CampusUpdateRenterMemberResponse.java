// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusUpdateRenterMemberResponseBody body;

    public static CampusUpdateRenterMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateRenterMemberResponse self = new CampusUpdateRenterMemberResponse();
        return TeaModel.build(map, self);
    }

    public CampusUpdateRenterMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusUpdateRenterMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusUpdateRenterMemberResponse setBody(CampusUpdateRenterMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusUpdateRenterMemberResponseBody getBody() {
        return this.body;
    }

}
