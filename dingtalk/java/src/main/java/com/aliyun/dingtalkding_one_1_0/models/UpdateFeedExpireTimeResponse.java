// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class UpdateFeedExpireTimeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFeedExpireTimeResponseBody body;

    public static UpdateFeedExpireTimeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFeedExpireTimeResponse self = new UpdateFeedExpireTimeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFeedExpireTimeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFeedExpireTimeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFeedExpireTimeResponse setBody(UpdateFeedExpireTimeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFeedExpireTimeResponseBody getBody() {
        return this.body;
    }

}
