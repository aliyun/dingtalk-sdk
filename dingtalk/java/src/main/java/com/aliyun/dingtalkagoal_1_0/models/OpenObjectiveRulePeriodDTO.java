// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenObjectiveRulePeriodDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1743436799000</p>
     */
    @NameInMap("endDate")
    public Long endDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2024年度</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("periodId")
    public String periodId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>season</p>
     */
    @NameInMap("periodType")
    public String periodType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1711900800000</p>
     */
    @NameInMap("startDate")
    public Long startDate;

    public static OpenObjectiveRulePeriodDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenObjectiveRulePeriodDTO self = new OpenObjectiveRulePeriodDTO();
        return TeaModel.build(map, self);
    }

    public OpenObjectiveRulePeriodDTO setEndDate(Long endDate) {
        this.endDate = endDate;
        return this;
    }
    public Long getEndDate() {
        return this.endDate;
    }

    public OpenObjectiveRulePeriodDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenObjectiveRulePeriodDTO setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public OpenObjectiveRulePeriodDTO setPeriodType(String periodType) {
        this.periodType = periodType;
        return this;
    }
    public String getPeriodType() {
        return this.periodType;
    }

    public OpenObjectiveRulePeriodDTO setStartDate(Long startDate) {
        this.startDate = startDate;
        return this;
    }
    public Long getStartDate() {
        return this.startDate;
    }

}
