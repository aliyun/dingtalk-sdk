// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class ListGroupBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListGroupBlackboardResponseBody body;

    public static ListGroupBlackboardResponse build(java.util.Map<String, ?> map) throws Exception {
        ListGroupBlackboardResponse self = new ListGroupBlackboardResponse();
        return TeaModel.build(map, self);
    }

    public ListGroupBlackboardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListGroupBlackboardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListGroupBlackboardResponse setBody(ListGroupBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public ListGroupBlackboardResponseBody getBody() {
        return this.body;
    }

}
