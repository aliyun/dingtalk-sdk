// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateReviewChecklistShrinkRequest extends TeaModel {
    @NameInMap("corp_id")
    public String corpId;

    @NameInMap("name")
    public String name;

    @NameInMap("rules")
    public String rulesShrink;

    public static UpdateReviewChecklistShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateReviewChecklistShrinkRequest self = new UpdateReviewChecklistShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UpdateReviewChecklistShrinkRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateReviewChecklistShrinkRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateReviewChecklistShrinkRequest setRulesShrink(String rulesShrink) {
        this.rulesShrink = rulesShrink;
        return this;
    }
    public String getRulesShrink() {
        return this.rulesShrink;
    }

}
