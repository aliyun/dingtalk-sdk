// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateChecklistRuleShrinkRequest extends TeaModel {
    @NameInMap("contract_type")
    public String contractType;

    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("description")
    public String description;

    @NameInMap("items")
    public String itemsShrink;

    @NameInMap("name")
    public String name;

    @NameInMap("risk_level")
    public String riskLevel;

    @NameInMap("standpoint")
    public String standpoint;

    public static CreateChecklistRuleShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateChecklistRuleShrinkRequest self = new CreateChecklistRuleShrinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateChecklistRuleShrinkRequest setContractType(String contractType) {
        this.contractType = contractType;
        return this;
    }
    public String getContractType() {
        return this.contractType;
    }

    public CreateChecklistRuleShrinkRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateChecklistRuleShrinkRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateChecklistRuleShrinkRequest setItemsShrink(String itemsShrink) {
        this.itemsShrink = itemsShrink;
        return this;
    }
    public String getItemsShrink() {
        return this.itemsShrink;
    }

    public CreateChecklistRuleShrinkRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateChecklistRuleShrinkRequest setRiskLevel(String riskLevel) {
        this.riskLevel = riskLevel;
        return this;
    }
    public String getRiskLevel() {
        return this.riskLevel;
    }

    public CreateChecklistRuleShrinkRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

}
