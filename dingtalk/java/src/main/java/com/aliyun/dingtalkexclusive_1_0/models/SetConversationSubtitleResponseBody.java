// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationSubtitleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetConversationSubtitleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetConversationSubtitleResponseBody self = new SetConversationSubtitleResponseBody();
        return TeaModel.build(map, self);
    }

    public SetConversationSubtitleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
