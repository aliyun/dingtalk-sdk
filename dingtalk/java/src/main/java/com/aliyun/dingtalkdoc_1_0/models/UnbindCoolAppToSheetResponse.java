// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UnbindCoolAppToSheetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UnbindCoolAppToSheetResponseBody body;

    public static UnbindCoolAppToSheetResponse build(java.util.Map<String, ?> map) throws Exception {
        UnbindCoolAppToSheetResponse self = new UnbindCoolAppToSheetResponse();
        return TeaModel.build(map, self);
    }

    public UnbindCoolAppToSheetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnbindCoolAppToSheetResponse setBody(UnbindCoolAppToSheetResponseBody body) {
        this.body = body;
        return this;
    }
    public UnbindCoolAppToSheetResponseBody getBody() {
        return this.body;
    }

}
