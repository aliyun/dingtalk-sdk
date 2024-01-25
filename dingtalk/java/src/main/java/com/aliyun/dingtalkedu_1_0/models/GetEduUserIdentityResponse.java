// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetEduUserIdentityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetEduUserIdentityResponseBody body;

    public static GetEduUserIdentityResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEduUserIdentityResponse self = new GetEduUserIdentityResponse();
        return TeaModel.build(map, self);
    }

    public GetEduUserIdentityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEduUserIdentityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetEduUserIdentityResponse setBody(GetEduUserIdentityResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEduUserIdentityResponseBody getBody() {
        return this.body;
    }

}
