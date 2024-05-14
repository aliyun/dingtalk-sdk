// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatSendResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static PrivateChatSendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PrivateChatSendResponseBody self = new PrivateChatSendResponseBody();
        return TeaModel.build(map, self);
    }

    public PrivateChatSendResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
