// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class StartCloudFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public StartCloudFeedResponseBody body;

    public static StartCloudFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        StartCloudFeedResponse self = new StartCloudFeedResponse();
        return TeaModel.build(map, self);
    }

    public StartCloudFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StartCloudFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public StartCloudFeedResponse setBody(StartCloudFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public StartCloudFeedResponseBody getBody() {
        return this.body;
    }

}
