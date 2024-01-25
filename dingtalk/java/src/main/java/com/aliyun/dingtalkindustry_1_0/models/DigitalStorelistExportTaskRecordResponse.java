// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStorelistExportTaskRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStorelistExportTaskRecordResponseBody body;

    public static DigitalStorelistExportTaskRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStorelistExportTaskRecordResponse self = new DigitalStorelistExportTaskRecordResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStorelistExportTaskRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStorelistExportTaskRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStorelistExportTaskRecordResponse setBody(DigitalStorelistExportTaskRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStorelistExportTaskRecordResponseBody getBody() {
        return this.body;
    }

}
