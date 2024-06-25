// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionCategoryStatisticsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220101</p>
     */
    @NameInMap("maxDt")
    public String maxDt;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20220101</p>
     */
    @NameInMap("minDt")
    public String minDt;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>KxisoOk</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static IntentionCategoryStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        IntentionCategoryStatisticsRequest self = new IntentionCategoryStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public IntentionCategoryStatisticsRequest setMaxDt(String maxDt) {
        this.maxDt = maxDt;
        return this;
    }
    public String getMaxDt() {
        return this.maxDt;
    }

    public IntentionCategoryStatisticsRequest setMinDt(String minDt) {
        this.minDt = minDt;
        return this;
    }
    public String getMinDt() {
        return this.minDt;
    }

    public IntentionCategoryStatisticsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
