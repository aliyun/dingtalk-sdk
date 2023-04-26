// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateLiveFeedResponseBody body;

    public static UpdateLiveFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveFeedResponse self = new UpdateLiveFeedResponse();
        return TeaModel.build(map, self);
    }

    public UpdateLiveFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateLiveFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateLiveFeedResponse setBody(UpdateLiveFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateLiveFeedResponseBody getBody() {
        return this.body;
    }

}
