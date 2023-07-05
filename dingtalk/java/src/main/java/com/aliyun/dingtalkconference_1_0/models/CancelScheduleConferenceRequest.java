// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CancelScheduleConferenceRequest extends TeaModel {
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    public static CancelScheduleConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelScheduleConferenceRequest self = new CancelScheduleConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CancelScheduleConferenceRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CancelScheduleConferenceRequest setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

}
