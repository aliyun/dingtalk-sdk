// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DeleteLiveFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteLiveFeedResponseBody body;

    public static DeleteLiveFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveFeedResponse self = new DeleteLiveFeedResponse();
        return TeaModel.build(map, self);
    }

    public DeleteLiveFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteLiveFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteLiveFeedResponse setBody(DeleteLiveFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteLiveFeedResponseBody getBody() {
        return this.body;
    }

}
