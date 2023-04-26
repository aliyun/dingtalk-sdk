// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListRenterMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CampusListRenterMembersResponseBody body;

    public static CampusListRenterMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusListRenterMembersResponse self = new CampusListRenterMembersResponse();
        return TeaModel.build(map, self);
    }

    public CampusListRenterMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusListRenterMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusListRenterMembersResponse setBody(CampusListRenterMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusListRenterMembersResponseBody getBody() {
        return this.body;
    }

}
