// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatSubAdminUpdateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public String success;

    public static ChatSubAdminUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatSubAdminUpdateResponseBody self = new ChatSubAdminUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatSubAdminUpdateResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
