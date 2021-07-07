// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class SaveCorpPayCodeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SaveCorpPayCodeResponseBody body;

    public static SaveCorpPayCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveCorpPayCodeResponse self = new SaveCorpPayCodeResponse();
        return TeaModel.build(map, self);
    }

    public SaveCorpPayCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveCorpPayCodeResponse setBody(SaveCorpPayCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveCorpPayCodeResponseBody getBody() {
        return this.body;
    }

}
