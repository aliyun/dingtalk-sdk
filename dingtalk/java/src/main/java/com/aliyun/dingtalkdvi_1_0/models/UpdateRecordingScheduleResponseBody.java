// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateRecordingScheduleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateRecordingScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRecordingScheduleResponseBody self = new UpdateRecordingScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRecordingScheduleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
