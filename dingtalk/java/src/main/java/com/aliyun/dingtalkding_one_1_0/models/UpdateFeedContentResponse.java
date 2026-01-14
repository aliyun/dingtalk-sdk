// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class UpdateFeedContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFeedContentResponseBody body;

    public static UpdateFeedContentResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFeedContentResponse self = new UpdateFeedContentResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFeedContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFeedContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFeedContentResponse setBody(UpdateFeedContentResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFeedContentResponseBody getBody() {
        return this.body;
    }

}
