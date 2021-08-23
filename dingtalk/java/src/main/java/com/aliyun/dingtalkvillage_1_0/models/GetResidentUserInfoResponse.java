// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetResidentUserInfoResponseBody body;

    public static GetResidentUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResidentUserInfoResponse self = new GetResidentUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResidentUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResidentUserInfoResponse setBody(GetResidentUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentUserInfoResponseBody getBody() {
        return this.body;
    }

}
