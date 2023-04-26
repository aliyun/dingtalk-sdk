// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CampusGetRenterMemberResponseBody body;

    public static CampusGetRenterMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusGetRenterMemberResponse self = new CampusGetRenterMemberResponse();
        return TeaModel.build(map, self);
    }

    public CampusGetRenterMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusGetRenterMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusGetRenterMemberResponse setBody(CampusGetRenterMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusGetRenterMemberResponseBody getBody() {
        return this.body;
    }

}
