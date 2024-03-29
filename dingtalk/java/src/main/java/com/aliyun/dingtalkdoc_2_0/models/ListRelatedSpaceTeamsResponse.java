// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedSpaceTeamsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListRelatedSpaceTeamsResponseBody body;

    public static ListRelatedSpaceTeamsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListRelatedSpaceTeamsResponse self = new ListRelatedSpaceTeamsResponse();
        return TeaModel.build(map, self);
    }

    public ListRelatedSpaceTeamsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListRelatedSpaceTeamsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListRelatedSpaceTeamsResponse setBody(ListRelatedSpaceTeamsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRelatedSpaceTeamsResponseBody getBody() {
        return this.body;
    }

}
