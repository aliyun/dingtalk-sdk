// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SaveIntegratedInstanceResponseBody body;

    public static SaveIntegratedInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceResponse self = new SaveIntegratedInstanceResponse();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveIntegratedInstanceResponse setBody(SaveIntegratedInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveIntegratedInstanceResponseBody getBody() {
        return this.body;
    }

}
