// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgTextEmotionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteOrgTextEmotionResponseBody body;

    public static DeleteOrgTextEmotionResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteOrgTextEmotionResponse self = new DeleteOrgTextEmotionResponse();
        return TeaModel.build(map, self);
    }

    public DeleteOrgTextEmotionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteOrgTextEmotionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteOrgTextEmotionResponse setBody(DeleteOrgTextEmotionResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteOrgTextEmotionResponseBody getBody() {
        return this.body;
    }

}
