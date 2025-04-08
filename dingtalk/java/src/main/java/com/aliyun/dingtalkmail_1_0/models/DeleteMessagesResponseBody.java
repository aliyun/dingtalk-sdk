// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class DeleteMessagesResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DeleteMessagesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMessagesResponseBody self = new DeleteMessagesResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMessagesResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
