// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetBookkeepingUserListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetBookkeepingUserListResponseBody body;

    public static GetBookkeepingUserListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBookkeepingUserListResponse self = new GetBookkeepingUserListResponse();
        return TeaModel.build(map, self);
    }

    public GetBookkeepingUserListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBookkeepingUserListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBookkeepingUserListResponse setBody(GetBookkeepingUserListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBookkeepingUserListResponseBody getBody() {
        return this.body;
    }

}
