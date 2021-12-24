// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class JoinGroupSetResponseBody extends TeaModel {
    // 进群是否成功。
    @NameInMap("success")
    public Boolean success;

    // 加密群ID。
    @NameInMap("openConversationId")
    public String openConversationId;

    public static JoinGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        JoinGroupSetResponseBody self = new JoinGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public JoinGroupSetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public JoinGroupSetResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
