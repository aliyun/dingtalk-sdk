// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class DeleteFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteFeedResponseBody body;

    public static DeleteFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteFeedResponse self = new DeleteFeedResponse();
        return TeaModel.build(map, self);
    }

    public DeleteFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteFeedResponse setBody(DeleteFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteFeedResponseBody getBody() {
        return this.body;
    }

}
