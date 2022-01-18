// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetOrgAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOrgAuthInfoResponseBody body;

    public static GetOrgAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgAuthInfoResponse self = new GetOrgAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgAuthInfoResponse setBody(GetOrgAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgAuthInfoResponseBody getBody() {
        return this.body;
    }

}
