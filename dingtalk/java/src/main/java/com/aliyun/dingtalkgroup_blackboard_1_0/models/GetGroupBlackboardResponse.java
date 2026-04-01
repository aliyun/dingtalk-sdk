// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class GetGroupBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetGroupBlackboardResponseBody body;

    public static GetGroupBlackboardResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupBlackboardResponse self = new GetGroupBlackboardResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupBlackboardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupBlackboardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGroupBlackboardResponse setBody(GetGroupBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupBlackboardResponseBody getBody() {
        return this.body;
    }

}
