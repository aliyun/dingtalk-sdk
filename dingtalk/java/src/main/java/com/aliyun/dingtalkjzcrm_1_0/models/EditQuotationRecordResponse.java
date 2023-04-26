// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditQuotationRecordResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EditQuotationRecordResponseBody body;

    public static EditQuotationRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        EditQuotationRecordResponse self = new EditQuotationRecordResponse();
        return TeaModel.build(map, self);
    }

    public EditQuotationRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditQuotationRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditQuotationRecordResponse setBody(EditQuotationRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public EditQuotationRecordResponseBody getBody() {
        return this.body;
    }

}
