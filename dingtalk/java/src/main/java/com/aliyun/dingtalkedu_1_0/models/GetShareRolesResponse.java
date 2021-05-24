// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetShareRolesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetShareRolesResponseBody body;

    public static GetShareRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShareRolesResponse self = new GetShareRolesResponse();
        return TeaModel.build(map, self);
    }

    public GetShareRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetShareRolesResponse setBody(GetShareRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetShareRolesResponseBody getBody() {
        return this.body;
    }

}
