// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserByDingTalkIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserByDingTalkIdResponseBody body;

    public static GetUserByDingTalkIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserByDingTalkIdResponse self = new GetUserByDingTalkIdResponse();
        return TeaModel.build(map, self);
    }

    public GetUserByDingTalkIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserByDingTalkIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserByDingTalkIdResponse setBody(GetUserByDingTalkIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserByDingTalkIdResponseBody getBody() {
        return this.body;
    }

}
