// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CancelScheduleConferenceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iP7Pxxxxxxxxxxxx</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2a489xxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</p>
     */
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
