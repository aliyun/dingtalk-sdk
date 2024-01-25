// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GroupUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GroupUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupUpdateResponse setBody(GroupUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupUpdateResponseBody getBody() {
        return this.body;
    }

}
