// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class TruncateSheetRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TruncateSheetRecordsResponseBody body;

    public static TruncateSheetRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        TruncateSheetRecordsResponse self = new TruncateSheetRecordsResponse();
        return TeaModel.build(map, self);
    }

    public TruncateSheetRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TruncateSheetRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TruncateSheetRecordsResponse setBody(TruncateSheetRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public TruncateSheetRecordsResponseBody getBody() {
        return this.body;
    }

}
