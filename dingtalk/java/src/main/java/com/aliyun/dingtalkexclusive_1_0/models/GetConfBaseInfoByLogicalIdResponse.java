// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConfBaseInfoByLogicalIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetConfBaseInfoByLogicalIdResponseBody body;

    public static GetConfBaseInfoByLogicalIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConfBaseInfoByLogicalIdResponse self = new GetConfBaseInfoByLogicalIdResponse();
        return TeaModel.build(map, self);
    }

    public GetConfBaseInfoByLogicalIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConfBaseInfoByLogicalIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConfBaseInfoByLogicalIdResponse setBody(GetConfBaseInfoByLogicalIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConfBaseInfoByLogicalIdResponseBody getBody() {
        return this.body;
    }

}
