// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetUserFollowStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserFollowStatusResponseBody body;

    public static GetUserFollowStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserFollowStatusResponse self = new GetUserFollowStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetUserFollowStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserFollowStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserFollowStatusResponse setBody(GetUserFollowStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserFollowStatusResponseBody getBody() {
        return this.body;
    }

}
