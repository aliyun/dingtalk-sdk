// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementBtripTrainResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BillSettementBtripTrainResponseBody body;

    public static BillSettementBtripTrainResponse build(java.util.Map<String, ?> map) throws Exception {
        BillSettementBtripTrainResponse self = new BillSettementBtripTrainResponse();
        return TeaModel.build(map, self);
    }

    public BillSettementBtripTrainResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BillSettementBtripTrainResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BillSettementBtripTrainResponse setBody(BillSettementBtripTrainResponseBody body) {
        this.body = body;
        return this;
    }
    public BillSettementBtripTrainResponseBody getBody() {
        return this.body;
    }

}
