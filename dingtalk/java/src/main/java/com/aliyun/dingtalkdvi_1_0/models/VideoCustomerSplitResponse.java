// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class VideoCustomerSplitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public VideoCustomerSplitResponseBody body;

    public static VideoCustomerSplitResponse build(java.util.Map<String, ?> map) throws Exception {
        VideoCustomerSplitResponse self = new VideoCustomerSplitResponse();
        return TeaModel.build(map, self);
    }

    public VideoCustomerSplitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public VideoCustomerSplitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public VideoCustomerSplitResponse setBody(VideoCustomerSplitResponseBody body) {
        this.body = body;
        return this;
    }
    public VideoCustomerSplitResponseBody getBody() {
        return this.body;
    }

}
