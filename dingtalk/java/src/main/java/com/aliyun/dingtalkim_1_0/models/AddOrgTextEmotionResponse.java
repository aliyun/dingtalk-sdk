// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddOrgTextEmotionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddOrgTextEmotionResponseBody body;

    public static AddOrgTextEmotionResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOrgTextEmotionResponse self = new AddOrgTextEmotionResponse();
        return TeaModel.build(map, self);
    }

    public AddOrgTextEmotionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOrgTextEmotionResponse setBody(AddOrgTextEmotionResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOrgTextEmotionResponseBody getBody() {
        return this.body;
    }

}
