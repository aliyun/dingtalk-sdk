// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseHumanSessionResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sessionId")
    public Long sessionId;

    public static CloseHumanSessionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseHumanSessionResponseBody self = new CloseHumanSessionResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseHumanSessionResponseBody setSessionId(Long sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public Long getSessionId() {
        return this.sessionId;
    }

}
