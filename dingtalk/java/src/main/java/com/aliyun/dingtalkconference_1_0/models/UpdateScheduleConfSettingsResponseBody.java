// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateScheduleConfSettingsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateScheduleConfSettingsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateScheduleConfSettingsResponseBody self = new UpdateScheduleConfSettingsResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateScheduleConfSettingsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
