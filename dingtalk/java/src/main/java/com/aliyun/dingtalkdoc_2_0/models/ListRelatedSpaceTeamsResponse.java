// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedSpaceTeamsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListRelatedSpaceTeamsResponse setBody(ListRelatedSpaceTeamsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRelatedSpaceTeamsResponseBody getBody() {
        return this.body;
    }

}
