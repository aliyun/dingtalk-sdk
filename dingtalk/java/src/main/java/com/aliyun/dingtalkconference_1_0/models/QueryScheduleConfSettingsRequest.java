// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConfSettingsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    public static QueryScheduleConfSettingsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConfSettingsRequest self = new QueryScheduleConfSettingsRequest();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConfSettingsRequest setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

}
