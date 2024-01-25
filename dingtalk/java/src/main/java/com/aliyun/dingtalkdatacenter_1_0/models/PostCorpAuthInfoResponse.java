// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class PostCorpAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PostCorpAuthInfoResponseBody body;

    public static PostCorpAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        PostCorpAuthInfoResponse self = new PostCorpAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public PostCorpAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PostCorpAuthInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PostCorpAuthInfoResponse setBody(PostCorpAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public PostCorpAuthInfoResponseBody getBody() {
        return this.body;
    }

}
