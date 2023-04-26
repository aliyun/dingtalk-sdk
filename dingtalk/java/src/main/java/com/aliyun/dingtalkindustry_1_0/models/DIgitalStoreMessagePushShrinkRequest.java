// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DIgitalStoreMessagePushShrinkRequest extends TeaModel {
    @NameInMap("messageDataList")
    public String messageDataListShrink;

    public static DIgitalStoreMessagePushShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        DIgitalStoreMessagePushShrinkRequest self = new DIgitalStoreMessagePushShrinkRequest();
        return TeaModel.build(map, self);
    }

    public DIgitalStoreMessagePushShrinkRequest setMessageDataListShrink(String messageDataListShrink) {
        this.messageDataListShrink = messageDataListShrink;
        return this;
    }
    public String getMessageDataListShrink() {
        return this.messageDataListShrink;
    }

}
