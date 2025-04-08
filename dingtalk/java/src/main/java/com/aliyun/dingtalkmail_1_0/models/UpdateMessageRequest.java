// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class UpdateMessageRequest extends TeaModel {
    @NameInMap("message")
    public DraftMessage message;

    public static UpdateMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMessageRequest self = new UpdateMessageRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMessageRequest setMessage(DraftMessage message) {
        this.message = message;
        return this;
    }
    public DraftMessage getMessage() {
        return this.message;
    }

}
