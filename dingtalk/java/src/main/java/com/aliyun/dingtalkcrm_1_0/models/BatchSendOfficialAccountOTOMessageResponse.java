// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOfficialAccountOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchSendOfficialAccountOTOMessageResponseBody body;

    public static BatchSendOfficialAccountOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOfficialAccountOTOMessageResponse self = new BatchSendOfficialAccountOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public BatchSendOfficialAccountOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchSendOfficialAccountOTOMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchSendOfficialAccountOTOMessageResponse setBody(BatchSendOfficialAccountOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchSendOfficialAccountOTOMessageResponseBody getBody() {
        return this.body;
    }

}
