// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListPendingPublishAuditsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListPendingPublishAuditsResponseBody body;

    public static ListPendingPublishAuditsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListPendingPublishAuditsResponse self = new ListPendingPublishAuditsResponse();
        return TeaModel.build(map, self);
    }

    public ListPendingPublishAuditsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListPendingPublishAuditsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListPendingPublishAuditsResponse setBody(ListPendingPublishAuditsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListPendingPublishAuditsResponseBody getBody() {
        return this.body;
    }

}
