// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class CreateMessageRequest extends TeaModel {
    @NameInMap("message")
    public DraftMessage message;

    public static CreateMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMessageRequest self = new CreateMessageRequest();
        return TeaModel.build(map, self);
    }

    public CreateMessageRequest setMessage(DraftMessage message) {
        this.message = message;
        return this;
    }
    public DraftMessage getMessage() {
        return this.message;
    }

}
