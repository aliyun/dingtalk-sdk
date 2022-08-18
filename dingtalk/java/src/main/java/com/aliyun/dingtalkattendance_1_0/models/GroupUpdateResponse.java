// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GroupUpdateResponseBody body;

    public static GroupUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupUpdateResponse self = new GroupUpdateResponse();
        return TeaModel.build(map, self);
    }

    public GroupUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupUpdateResponse setBody(GroupUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupUpdateResponseBody getBody() {
        return this.body;
    }

}
