// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetOrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOrgInfoResponseBody body;

    public static GetOrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgInfoResponse self = new GetOrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgInfoResponse setBody(GetOrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgInfoResponseBody getBody() {
        return this.body;
    }

}
