// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreExportCardRecordDetailResponseBody body;

    public static DigitalStoreExportCardRecordDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreExportCardRecordDetailResponse self = new DigitalStoreExportCardRecordDetailResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreExportCardRecordDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreExportCardRecordDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreExportCardRecordDetailResponse setBody(DigitalStoreExportCardRecordDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreExportCardRecordDetailResponseBody getBody() {
        return this.body;
    }

}
