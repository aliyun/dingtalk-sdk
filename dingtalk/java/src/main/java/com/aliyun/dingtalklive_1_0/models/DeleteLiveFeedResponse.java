// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DeleteLiveFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteLiveFeedResponse setBody(DeleteLiveFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteLiveFeedResponseBody getBody() {
        return this.body;
    }

}
