// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class EditGroupBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditGroupBlackboardResponseBody body;

    public static EditGroupBlackboardResponse build(java.util.Map<String, ?> map) throws Exception {
        EditGroupBlackboardResponse self = new EditGroupBlackboardResponse();
        return TeaModel.build(map, self);
    }

    public EditGroupBlackboardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditGroupBlackboardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditGroupBlackboardResponse setBody(EditGroupBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public EditGroupBlackboardResponseBody getBody() {
        return this.body;
    }

}
