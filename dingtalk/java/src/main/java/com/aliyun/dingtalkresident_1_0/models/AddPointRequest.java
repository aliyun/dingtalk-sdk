// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddPointRequest extends TeaModel {
    @NameInMap("actionTime")
    public Long actionTime;

    @NameInMap("isCircle")
    public Boolean isCircle;

    @NameInMap("ruleCode")
    public String ruleCode;

    @NameInMap("ruleName")
    public String ruleName;

    @NameInMap("score")
    public Integer score;

    @NameInMap("userId")
    public String userId;

    @NameInMap("uuid")
    public String uuid;

    public static AddPointRequest build(java.util.Map<String, ?> map) throws Exception {
        AddPointRequest self = new AddPointRequest();
        return TeaModel.build(map, self);
    }

    public AddPointRequest setActionTime(Long actionTime) {
        this.actionTime = actionTime;
        return this;
    }
    public Long getActionTime() {
        return this.actionTime;
    }

    public AddPointRequest setIsCircle(Boolean isCircle) {
        this.isCircle = isCircle;
        return this;
    }
    public Boolean getIsCircle() {
        return this.isCircle;
    }

    public AddPointRequest setRuleCode(String ruleCode) {
        this.ruleCode = ruleCode;
        return this;
    }
    public String getRuleCode() {
        return this.ruleCode;
    }

    public AddPointRequest setRuleName(String ruleName) {
        this.ruleName = ruleName;
        return this;
    }
    public String getRuleName() {
        return this.ruleName;
    }

    public AddPointRequest setScore(Integer score) {
        this.score = score;
        return this;
    }
    public Integer getScore() {
        return this.score;
    }

    public AddPointRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AddPointRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
