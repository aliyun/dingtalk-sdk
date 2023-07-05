// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateScheduleConferenceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateScheduleConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateScheduleConferenceResponseBody self = new UpdateScheduleConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateScheduleConferenceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
