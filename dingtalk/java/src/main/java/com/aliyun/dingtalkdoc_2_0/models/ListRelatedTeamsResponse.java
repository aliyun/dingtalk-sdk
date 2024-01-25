// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedTeamsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListRelatedTeamsResponseBody body;

    public static ListRelatedTeamsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListRelatedTeamsResponse self = new ListRelatedTeamsResponse();
        return TeaModel.build(map, self);
    }

    public ListRelatedTeamsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListRelatedTeamsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListRelatedTeamsResponse setBody(ListRelatedTeamsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRelatedTeamsResponseBody getBody() {
        return this.body;
    }

}
