// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecordingScheduleResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteRecordingScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecordingScheduleResponseBody self = new DeleteRecordingScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRecordingScheduleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
