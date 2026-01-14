// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiTaskShrinkRequest extends TeaModel {
    @NameInMap("messages")
    public String messagesShrink;

    public static SubmitAiTaskShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiTaskShrinkRequest self = new SubmitAiTaskShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SubmitAiTaskShrinkRequest setMessagesShrink(String messagesShrink) {
        this.messagesShrink = messagesShrink;
        return this;
    }
    public String getMessagesShrink() {
        return this.messagesShrink;
    }

}
