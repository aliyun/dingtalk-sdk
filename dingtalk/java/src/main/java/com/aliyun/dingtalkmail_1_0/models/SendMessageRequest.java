// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class SendMessageRequest extends TeaModel {
    @NameInMap("saveToSentItems")
    public Boolean saveToSentItems;

    public static SendMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendMessageRequest self = new SendMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendMessageRequest setSaveToSentItems(Boolean saveToSentItems) {
        this.saveToSentItems = saveToSentItems;
        return this;
    }
    public Boolean getSaveToSentItems() {
        return this.saveToSentItems;
    }

}
