// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class LockConferenceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static LockConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LockConferenceResponseBody self = new LockConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public LockConferenceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
