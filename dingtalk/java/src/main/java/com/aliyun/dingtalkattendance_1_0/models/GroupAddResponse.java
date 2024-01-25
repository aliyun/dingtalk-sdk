// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GroupAddResponseBody body;

    public static GroupAddResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupAddResponse self = new GroupAddResponse();
        return TeaModel.build(map, self);
    }

    public GroupAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupAddResponse setBody(GroupAddResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupAddResponseBody getBody() {
        return this.body;
    }

}
