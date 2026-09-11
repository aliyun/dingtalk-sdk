// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ConfirmContractReviewShrinkRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("checklist_id")
    public String checklistId;

    @NameInMap("contract_type")
    public String contractType;

    @NameInMap("custom_rules")
    public String customRulesShrink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("review_id")
    public String reviewId;

    @NameInMap("scale")
    public String scale;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("session_id")
    public String sessionId;

    @NameInMap("standpoint")
    public String standpoint;

    public static ConfirmContractReviewShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmContractReviewShrinkRequest self = new ConfirmContractReviewShrinkRequest();
        return TeaModel.build(map, self);
    }

    public ConfirmContractReviewShrinkRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public ConfirmContractReviewShrinkRequest setChecklistId(String checklistId) {
        this.checklistId = checklistId;
        return this;
    }
    public String getChecklistId() {
        return this.checklistId;
    }

    public ConfirmContractReviewShrinkRequest setContractType(String contractType) {
        this.contractType = contractType;
        return this;
    }
    public String getContractType() {
        return this.contractType;
    }

    public ConfirmContractReviewShrinkRequest setCustomRulesShrink(String customRulesShrink) {
        this.customRulesShrink = customRulesShrink;
        return this;
    }
    public String getCustomRulesShrink() {
        return this.customRulesShrink;
    }

    public ConfirmContractReviewShrinkRequest setReviewId(String reviewId) {
        this.reviewId = reviewId;
        return this;
    }
    public String getReviewId() {
        return this.reviewId;
    }

    public ConfirmContractReviewShrinkRequest setScale(String scale) {
        this.scale = scale;
        return this;
    }
    public String getScale() {
        return this.scale;
    }

    public ConfirmContractReviewShrinkRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

    public ConfirmContractReviewShrinkRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

}
