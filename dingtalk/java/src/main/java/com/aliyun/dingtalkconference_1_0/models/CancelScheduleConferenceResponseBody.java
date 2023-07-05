// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CancelScheduleConferenceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CancelScheduleConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelScheduleConferenceResponseBody self = new CancelScheduleConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelScheduleConferenceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
