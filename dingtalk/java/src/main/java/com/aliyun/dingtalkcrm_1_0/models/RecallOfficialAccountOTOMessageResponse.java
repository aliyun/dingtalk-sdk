// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class RecallOfficialAccountOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RecallOfficialAccountOTOMessageResponseBody body;

    public static RecallOfficialAccountOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        RecallOfficialAccountOTOMessageResponse self = new RecallOfficialAccountOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public RecallOfficialAccountOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RecallOfficialAccountOTOMessageResponse setBody(RecallOfficialAccountOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public RecallOfficialAccountOTOMessageResponseBody getBody() {
        return this.body;
    }

}
