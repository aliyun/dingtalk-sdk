// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetInActiveUserListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetInActiveUserListResponseBody body;

    public static GetInActiveUserListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInActiveUserListResponse self = new GetInActiveUserListResponse();
        return TeaModel.build(map, self);
    }

    public GetInActiveUserListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInActiveUserListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInActiveUserListResponse setBody(GetInActiveUserListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInActiveUserListResponseBody getBody() {
        return this.body;
    }

}
