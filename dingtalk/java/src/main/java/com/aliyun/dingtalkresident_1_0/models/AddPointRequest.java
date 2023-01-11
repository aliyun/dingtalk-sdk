// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddPointRequest extends TeaModel {
    /**
     * <p>增加积分的时间戳毫秒数，如果为空使用系统当前毫秒数</p>
     */
    @NameInMap("actionTime")
    public Long actionTime;

    /**
     * <p>是否查询全员圈积分</p>
     */
    @NameInMap("isCircle")
    public Boolean isCircle;

    /**
     * <p>规则代码（可空）,如果不为空的话，score值使用ruleCode对应的score增加分数</p>
     */
    @NameInMap("ruleCode")
    public String ruleCode;

    /**
     * <p>规则名字</p>
     */
    @NameInMap("ruleName")
    public String ruleName;

    /**
     * <p>本次增加积分：正数表示增加/负数表示扣减</p>
     */
    @NameInMap("score")
    public Integer score;

    /**
     * <p>成员id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>加积分的唯一幂等标志</p>
     */
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
