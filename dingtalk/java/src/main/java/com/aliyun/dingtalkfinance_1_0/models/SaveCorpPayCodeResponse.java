// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class SaveCorpPayCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public SaveCorpPayCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveCorpPayCodeResponse setBody(SaveCorpPayCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveCorpPayCodeResponseBody getBody() {
        return this.body;
    }

}
