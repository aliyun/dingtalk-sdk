// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomfieldValueResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateCustomfieldValueResponseBody body;

    public static UpdateCustomfieldValueResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomfieldValueResponse self = new UpdateCustomfieldValueResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCustomfieldValueResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCustomfieldValueResponse setBody(UpdateCustomfieldValueResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCustomfieldValueResponseBody getBody() {
        return this.body;
    }

}
