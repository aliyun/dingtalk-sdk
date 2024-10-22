// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRobotInfoByCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRobotInfoByCodeResponseBody body;

    public static GetRobotInfoByCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRobotInfoByCodeResponse self = new GetRobotInfoByCodeResponse();
        return TeaModel.build(map, self);
    }

    public GetRobotInfoByCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRobotInfoByCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRobotInfoByCodeResponse setBody(GetRobotInfoByCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRobotInfoByCodeResponseBody getBody() {
        return this.body;
    }

}
