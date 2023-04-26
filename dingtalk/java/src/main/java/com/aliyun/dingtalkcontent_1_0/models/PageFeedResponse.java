// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class PageFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PageFeedResponseBody body;

    public static PageFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        PageFeedResponse self = new PageFeedResponse();
        return TeaModel.build(map, self);
    }

    public PageFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageFeedResponse setBody(PageFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public PageFeedResponseBody getBody() {
        return this.body;
    }

}
