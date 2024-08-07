// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateDlpTaskResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static CreateDlpTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDlpTaskResponseBody self = new CreateDlpTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDlpTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
