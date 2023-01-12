// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateSheetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateSheetResponseBody body;

    public static UpdateSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSheetResponse self = new UpdateSheetResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateSheetResponse setBody(UpdateSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateSheetResponseBody getBody() {
        return this.body;
    }

}
