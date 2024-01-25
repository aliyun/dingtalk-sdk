// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDelRenterMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusDelRenterMemberResponseBody body;

    public static CampusDelRenterMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusDelRenterMemberResponse self = new CampusDelRenterMemberResponse();
        return TeaModel.build(map, self);
    }

    public CampusDelRenterMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusDelRenterMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusDelRenterMemberResponse setBody(CampusDelRenterMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusDelRenterMemberResponseBody getBody() {
        return this.body;
    }

}
