// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgTextEmotionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteOrgTextEmotionResponse setBody(DeleteOrgTextEmotionResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteOrgTextEmotionResponseBody getBody() {
        return this.body;
    }

}
