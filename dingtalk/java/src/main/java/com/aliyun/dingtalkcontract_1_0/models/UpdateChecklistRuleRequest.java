// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateChecklistRuleRequest extends TeaModel {
    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("description")
    public String description;

    @NameInMap("name")
    public String name;

    @NameInMap("risk_level")
    public String riskLevel;

    @NameInMap("standpoint")
    public String standpoint;

    public static UpdateChecklistRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateChecklistRuleRequest self = new UpdateChecklistRuleRequest();
        return TeaModel.build(map, self);
    }

    public UpdateChecklistRuleRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateChecklistRuleRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateChecklistRuleRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateChecklistRuleRequest setRiskLevel(String riskLevel) {
        this.riskLevel = riskLevel;
        return this;
    }
    public String getRiskLevel() {
        return this.riskLevel;
    }

    public UpdateChecklistRuleRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

}
