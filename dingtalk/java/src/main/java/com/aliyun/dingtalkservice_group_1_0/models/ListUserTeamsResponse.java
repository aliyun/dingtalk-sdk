// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ListUserTeamsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListUserTeamsResponseBody body;

    public static ListUserTeamsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUserTeamsResponse self = new ListUserTeamsResponse();
        return TeaModel.build(map, self);
    }

    public ListUserTeamsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListUserTeamsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListUserTeamsResponse setBody(ListUserTeamsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListUserTeamsResponseBody getBody() {
        return this.body;
    }

}
