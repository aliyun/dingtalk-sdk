// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GroupManageQueryResponseBody body;

    public static GroupManageQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupManageQueryResponse self = new GroupManageQueryResponse();
        return TeaModel.build(map, self);
    }

    public GroupManageQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupManageQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupManageQueryResponse setBody(GroupManageQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupManageQueryResponseBody getBody() {
        return this.body;
    }

}
