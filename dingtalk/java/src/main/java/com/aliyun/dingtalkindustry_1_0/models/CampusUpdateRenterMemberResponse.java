// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CampusUpdateRenterMemberResponse setBody(CampusUpdateRenterMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusUpdateRenterMemberResponseBody getBody() {
        return this.body;
    }

}
