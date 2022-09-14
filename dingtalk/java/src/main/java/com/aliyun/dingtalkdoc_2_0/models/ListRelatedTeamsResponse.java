// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedTeamsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListRelatedTeamsResponse setBody(ListRelatedTeamsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRelatedTeamsResponseBody getBody() {
        return this.body;
    }

}
