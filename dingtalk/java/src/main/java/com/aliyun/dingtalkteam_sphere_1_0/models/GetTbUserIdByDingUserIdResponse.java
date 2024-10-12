// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByDingUserIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTbUserIdByDingUserIdResponseBody body;

    public static GetTbUserIdByDingUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTbUserIdByDingUserIdResponse self = new GetTbUserIdByDingUserIdResponse();
        return TeaModel.build(map, self);
    }

    public GetTbUserIdByDingUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTbUserIdByDingUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTbUserIdByDingUserIdResponse setBody(GetTbUserIdByDingUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTbUserIdByDingUserIdResponseBody getBody() {
        return this.body;
    }

}
