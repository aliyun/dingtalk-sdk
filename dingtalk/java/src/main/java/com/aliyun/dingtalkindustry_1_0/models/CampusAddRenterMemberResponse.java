// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusAddRenterMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusAddRenterMemberResponseBody body;

    public static CampusAddRenterMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusAddRenterMemberResponse self = new CampusAddRenterMemberResponse();
        return TeaModel.build(map, self);
    }

    public CampusAddRenterMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusAddRenterMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusAddRenterMemberResponse setBody(CampusAddRenterMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusAddRenterMemberResponseBody getBody() {
        return this.body;
    }

}
