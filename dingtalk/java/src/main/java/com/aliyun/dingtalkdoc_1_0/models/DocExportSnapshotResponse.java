// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocExportSnapshotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocExportSnapshotResponseBody body;

    public static DocExportSnapshotResponse build(java.util.Map<String, ?> map) throws Exception {
        DocExportSnapshotResponse self = new DocExportSnapshotResponse();
        return TeaModel.build(map, self);
    }

    public DocExportSnapshotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocExportSnapshotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocExportSnapshotResponse setBody(DocExportSnapshotResponseBody body) {
        this.body = body;
        return this;
    }
    public DocExportSnapshotResponseBody getBody() {
        return this.body;
    }

}
