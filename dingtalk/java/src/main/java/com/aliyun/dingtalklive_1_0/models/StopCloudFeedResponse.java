// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class StopCloudFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public StopCloudFeedResponseBody body;

    public static StopCloudFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        StopCloudFeedResponse self = new StopCloudFeedResponse();
        return TeaModel.build(map, self);
    }

    public StopCloudFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StopCloudFeedResponse setBody(StopCloudFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public StopCloudFeedResponseBody getBody() {
        return this.body;
    }

}
