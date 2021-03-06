// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateCloudFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateCloudFeedResponse setBody(CreateCloudFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCloudFeedResponseBody getBody() {
        return this.body;
    }

}
