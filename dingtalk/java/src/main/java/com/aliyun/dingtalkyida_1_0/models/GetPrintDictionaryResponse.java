// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPrintDictionaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrintDictionaryResponseBody body;

    public static GetPrintDictionaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrintDictionaryResponse self = new GetPrintDictionaryResponse();
        return TeaModel.build(map, self);
    }

    public GetPrintDictionaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrintDictionaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrintDictionaryResponse setBody(GetPrintDictionaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrintDictionaryResponseBody getBody() {
        return this.body;
    }

}
