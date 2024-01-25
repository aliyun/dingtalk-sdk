// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SavePrintTplDetailInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SavePrintTplDetailInfoResponseBody body;

    public static SavePrintTplDetailInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SavePrintTplDetailInfoResponse self = new SavePrintTplDetailInfoResponse();
        return TeaModel.build(map, self);
    }

    public SavePrintTplDetailInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SavePrintTplDetailInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SavePrintTplDetailInfoResponse setBody(SavePrintTplDetailInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SavePrintTplDetailInfoResponseBody getBody() {
        return this.body;
    }

}
