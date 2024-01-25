// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateCloudFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCloudFeedResponseBody body;

    public static CreateCloudFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCloudFeedResponse self = new CreateCloudFeedResponse();
        return TeaModel.build(map, self);
    }

    public CreateCloudFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCloudFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCloudFeedResponse setBody(CreateCloudFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCloudFeedResponseBody getBody() {
        return this.body;
    }

}
