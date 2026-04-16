// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetDeptScoreCardIndicatorRequest extends TeaModel {
    @NameInMap("dingTeamId")
    public String dingTeamId;

    @NameInMap("selectedTime")
    public Long selectedTime;

    public static GetDeptScoreCardIndicatorRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDeptScoreCardIndicatorRequest self = new GetDeptScoreCardIndicatorRequest();
        return TeaModel.build(map, self);
    }

    public GetDeptScoreCardIndicatorRequest setDingTeamId(String dingTeamId) {
        this.dingTeamId = dingTeamId;
        return this;
    }
    public String getDingTeamId() {
        return this.dingTeamId;
    }

    public GetDeptScoreCardIndicatorRequest setSelectedTime(Long selectedTime) {
        this.selectedTime = selectedTime;
        return this;
    }
    public Long getSelectedTime() {
        return this.selectedTime;
    }

}
