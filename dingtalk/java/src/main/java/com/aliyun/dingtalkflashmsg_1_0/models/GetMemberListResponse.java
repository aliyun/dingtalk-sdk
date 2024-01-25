// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetMemberListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMemberListResponseBody body;

    public static GetMemberListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMemberListResponse self = new GetMemberListResponse();
        return TeaModel.build(map, self);
    }

    public GetMemberListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMemberListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMemberListResponse setBody(GetMemberListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMemberListResponseBody getBody() {
        return this.body;
    }

}
