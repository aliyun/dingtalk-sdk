// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class ModifyFeedWhiteListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ModifyFeedWhiteListResponseBody body;

    public static ModifyFeedWhiteListResponse build(java.util.Map<String, ?> map) throws Exception {
        ModifyFeedWhiteListResponse self = new ModifyFeedWhiteListResponse();
        return TeaModel.build(map, self);
    }

    public ModifyFeedWhiteListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ModifyFeedWhiteListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ModifyFeedWhiteListResponse setBody(ModifyFeedWhiteListResponseBody body) {
        this.body = body;
        return this;
    }
    public ModifyFeedWhiteListResponseBody getBody() {
        return this.body;
    }

}
