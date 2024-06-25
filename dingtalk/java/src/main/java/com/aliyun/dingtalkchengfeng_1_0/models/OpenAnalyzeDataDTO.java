// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class OpenAnalyzeDataDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("deptCount")
    public Integer deptCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>22</p>
     */
    @NameInMap("noAlignObjectiveCount")
    public Integer noAlignObjectiveCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33</p>
     */
    @NameInMap("noKeyActionCount")
    public Integer noKeyActionCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33.2</p>
     */
    @NameInMap("objectiveAlignRate")
    public Double objectiveAlignRate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("objectiveNoSetCount")
    public Integer objectiveNoSetCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11</p>
     */
    @NameInMap("objectiveRiskCount")
    public Integer objectiveRiskCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33.3</p>
     */
    @NameInMap("objectiveSetRate")
    public Double objectiveSetRate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>44</p>
     */
    @NameInMap("onlyOneKeyResultCount")
    public Integer onlyOneKeyResultCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33</p>
     */
    @NameInMap("onlyOneObjectiveCount")
    public Integer onlyOneObjectiveCount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>22.3</p>
     */
    @NameInMap("progressUpdateRateLast15Days")
    public Double progressUpdateRateLast15Days;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33.11</p>
     */
    @NameInMap("progressUpdateRateLast30Days")
    public Double progressUpdateRateLast30Days;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33.4</p>
     */
    @NameInMap("progressUpdateRateLast7Days")
    public Double progressUpdateRateLast7Days;

    public static OpenAnalyzeDataDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAnalyzeDataDTO self = new OpenAnalyzeDataDTO();
        return TeaModel.build(map, self);
    }

    public OpenAnalyzeDataDTO setDeptCount(Integer deptCount) {
        this.deptCount = deptCount;
        return this;
    }
    public Integer getDeptCount() {
        return this.deptCount;
    }

    public OpenAnalyzeDataDTO setNoAlignObjectiveCount(Integer noAlignObjectiveCount) {
        this.noAlignObjectiveCount = noAlignObjectiveCount;
        return this;
    }
    public Integer getNoAlignObjectiveCount() {
        return this.noAlignObjectiveCount;
    }

    public OpenAnalyzeDataDTO setNoKeyActionCount(Integer noKeyActionCount) {
        this.noKeyActionCount = noKeyActionCount;
        return this;
    }
    public Integer getNoKeyActionCount() {
        return this.noKeyActionCount;
    }

    public OpenAnalyzeDataDTO setObjectiveAlignRate(Double objectiveAlignRate) {
        this.objectiveAlignRate = objectiveAlignRate;
        return this;
    }
    public Double getObjectiveAlignRate() {
        return this.objectiveAlignRate;
    }

    public OpenAnalyzeDataDTO setObjectiveNoSetCount(Integer objectiveNoSetCount) {
        this.objectiveNoSetCount = objectiveNoSetCount;
        return this;
    }
    public Integer getObjectiveNoSetCount() {
        return this.objectiveNoSetCount;
    }

    public OpenAnalyzeDataDTO setObjectiveRiskCount(Integer objectiveRiskCount) {
        this.objectiveRiskCount = objectiveRiskCount;
        return this;
    }
    public Integer getObjectiveRiskCount() {
        return this.objectiveRiskCount;
    }

    public OpenAnalyzeDataDTO setObjectiveSetRate(Double objectiveSetRate) {
        this.objectiveSetRate = objectiveSetRate;
        return this;
    }
    public Double getObjectiveSetRate() {
        return this.objectiveSetRate;
    }

    public OpenAnalyzeDataDTO setOnlyOneKeyResultCount(Integer onlyOneKeyResultCount) {
        this.onlyOneKeyResultCount = onlyOneKeyResultCount;
        return this;
    }
    public Integer getOnlyOneKeyResultCount() {
        return this.onlyOneKeyResultCount;
    }

    public OpenAnalyzeDataDTO setOnlyOneObjectiveCount(Integer onlyOneObjectiveCount) {
        this.onlyOneObjectiveCount = onlyOneObjectiveCount;
        return this;
    }
    public Integer getOnlyOneObjectiveCount() {
        return this.onlyOneObjectiveCount;
    }

    public OpenAnalyzeDataDTO setProgressUpdateRateLast15Days(Double progressUpdateRateLast15Days) {
        this.progressUpdateRateLast15Days = progressUpdateRateLast15Days;
        return this;
    }
    public Double getProgressUpdateRateLast15Days() {
        return this.progressUpdateRateLast15Days;
    }

    public OpenAnalyzeDataDTO setProgressUpdateRateLast30Days(Double progressUpdateRateLast30Days) {
        this.progressUpdateRateLast30Days = progressUpdateRateLast30Days;
        return this;
    }
    public Double getProgressUpdateRateLast30Days() {
        return this.progressUpdateRateLast30Days;
    }

    public OpenAnalyzeDataDTO setProgressUpdateRateLast7Days(Double progressUpdateRateLast7Days) {
        this.progressUpdateRateLast7Days = progressUpdateRateLast7Days;
        return this;
    }
    public Double getProgressUpdateRateLast7Days() {
        return this.progressUpdateRateLast7Days;
    }

}
