// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupMembersFromGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteGroupMembersFromGroupResponseBody body;

    public static DeleteGroupMembersFromGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupMembersFromGroupResponse self = new DeleteGroupMembersFromGroupResponse();
        return TeaModel.build(map, self);
    }

    public DeleteGroupMembersFromGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteGroupMembersFromGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteGroupMembersFromGroupResponse setBody(DeleteGroupMembersFromGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteGroupMembersFromGroupResponseBody getBody() {
        return this.body;
    }

}
