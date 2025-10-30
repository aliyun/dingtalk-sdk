// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class GetBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetBlackboardResponseBody body;

    public static GetBlackboardResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBlackboardResponse self = new GetBlackboardResponse();
        return TeaModel.build(map, self);
    }

    public GetBlackboardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetBlackboardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetBlackboardResponse setBody(GetBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public GetBlackboardResponseBody getBody() {
        return this.body;
    }

}
