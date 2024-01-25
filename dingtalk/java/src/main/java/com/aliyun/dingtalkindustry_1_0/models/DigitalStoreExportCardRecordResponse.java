// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreExportCardRecordResponseBody body;

    public static DigitalStoreExportCardRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreExportCardRecordResponse self = new DigitalStoreExportCardRecordResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreExportCardRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreExportCardRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreExportCardRecordResponse setBody(DigitalStoreExportCardRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreExportCardRecordResponseBody getBody() {
        return this.body;
    }

}
