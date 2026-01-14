// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenObjectiveRuleDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("excludePopRuleView")
    public java.util.List<OpenObjectiveRuleScopeDTO> excludePopRuleView;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OKR / PBC</p>
     */
    @NameInMap("objectiveCategory")
    public String objectiveCategory;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("objectiveRuleId")
    public String objectiveRuleId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>规则</p>
     */
    @NameInMap("objectiveRuleName")
    public String objectiveRuleName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("periods")
    public java.util.List<OpenObjectiveRulePeriodDTO> periods;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("popRuleView")
    public java.util.List<OpenObjectiveRuleScopeDTO> popRuleView;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("probationRule")
    public Boolean probationRule;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ONLINE</p>
     */
    @NameInMap("status")
    public String status;

    public static OpenObjectiveRuleDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenObjectiveRuleDTO self = new OpenObjectiveRuleDTO();
        return TeaModel.build(map, self);
    }

    public OpenObjectiveRuleDTO setExcludePopRuleView(java.util.List<OpenObjectiveRuleScopeDTO> excludePopRuleView) {
        this.excludePopRuleView = excludePopRuleView;
        return this;
    }
    public java.util.List<OpenObjectiveRuleScopeDTO> getExcludePopRuleView() {
        return this.excludePopRuleView;
    }

    public OpenObjectiveRuleDTO setObjectiveCategory(String objectiveCategory) {
        this.objectiveCategory = objectiveCategory;
        return this;
    }
    public String getObjectiveCategory() {
        return this.objectiveCategory;
    }

    public OpenObjectiveRuleDTO setObjectiveRuleId(String objectiveRuleId) {
        this.objectiveRuleId = objectiveRuleId;
        return this;
    }
    public String getObjectiveRuleId() {
        return this.objectiveRuleId;
    }

    public OpenObjectiveRuleDTO setObjectiveRuleName(String objectiveRuleName) {
        this.objectiveRuleName = objectiveRuleName;
        return this;
    }
    public String getObjectiveRuleName() {
        return this.objectiveRuleName;
    }

    public OpenObjectiveRuleDTO setPeriods(java.util.List<OpenObjectiveRulePeriodDTO> periods) {
        this.periods = periods;
        return this;
    }
    public java.util.List<OpenObjectiveRulePeriodDTO> getPeriods() {
        return this.periods;
    }

    public OpenObjectiveRuleDTO setPopRuleView(java.util.List<OpenObjectiveRuleScopeDTO> popRuleView) {
        this.popRuleView = popRuleView;
        return this;
    }
    public java.util.List<OpenObjectiveRuleScopeDTO> getPopRuleView() {
        return this.popRuleView;
    }

    public OpenObjectiveRuleDTO setProbationRule(Boolean probationRule) {
        this.probationRule = probationRule;
        return this;
    }
    public Boolean getProbationRule() {
        return this.probationRule;
    }

    public OpenObjectiveRuleDTO setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
