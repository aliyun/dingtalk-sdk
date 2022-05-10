// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageQueryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GroupManageQueryResponse setBody(GroupManageQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupManageQueryResponseBody getBody() {
        return this.body;
    }

}
