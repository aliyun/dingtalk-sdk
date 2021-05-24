// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetShareRoleMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetShareRoleMembersResponseBody body;

    public static GetShareRoleMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShareRoleMembersResponse self = new GetShareRoleMembersResponse();
        return TeaModel.build(map, self);
    }

    public GetShareRoleMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetShareRoleMembersResponse setBody(GetShareRoleMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public GetShareRoleMembersResponseBody getBody() {
        return this.body;
    }

}
