// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDelRenterMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CampusDelRenterMemberResponse setBody(CampusDelRenterMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusDelRenterMemberResponseBody getBody() {
        return this.body;
    }

}
