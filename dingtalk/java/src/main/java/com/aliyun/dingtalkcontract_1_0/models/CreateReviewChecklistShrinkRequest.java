// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateReviewChecklistShrinkRequest extends TeaModel {
    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("name")
    public String name;

    @NameInMap("rules")
    public String rulesShrink;

    public static CreateReviewChecklistShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateReviewChecklistShrinkRequest self = new CreateReviewChecklistShrinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateReviewChecklistShrinkRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateReviewChecklistShrinkRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateReviewChecklistShrinkRequest setRulesShrink(String rulesShrink) {
        this.rulesShrink = rulesShrink;
        return this;
    }
    public String getRulesShrink() {
        return this.rulesShrink;
    }

}
