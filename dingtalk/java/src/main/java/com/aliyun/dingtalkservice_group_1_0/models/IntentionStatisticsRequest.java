// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionStatisticsRequest extends TeaModel {
    @NameInMap("maxDt")
    public String maxDt;

    @NameInMap("minDt")
    public String minDt;

    @NameInMap("openTeamId")
    public String openTeamId;

    public static IntentionStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        IntentionStatisticsRequest self = new IntentionStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public IntentionStatisticsRequest setMaxDt(String maxDt) {
        this.maxDt = maxDt;
        return this;
    }
    public String getMaxDt() {
        return this.maxDt;
    }

    public IntentionStatisticsRequest setMinDt(String minDt) {
        this.minDt = minDt;
        return this;
    }
    public String getMinDt() {
        return this.minDt;
    }

    public IntentionStatisticsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
