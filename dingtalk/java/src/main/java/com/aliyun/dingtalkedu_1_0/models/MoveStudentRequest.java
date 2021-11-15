// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class MoveStudentRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 管理员id
    @NameInMap("operator")
    public String operator;

    // 学生id
    @NameInMap("userId")
    public String userId;

    // 愿班级id
    @NameInMap("originClassId")
    public Long originClassId;

    // 目标班级id
    @NameInMap("targetClassId")
    public Long targetClassId;

    public static MoveStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveStudentRequest self = new MoveStudentRequest();
        return TeaModel.build(map, self);
    }

    public MoveStudentRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public MoveStudentRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public MoveStudentRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public MoveStudentRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public MoveStudentRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public MoveStudentRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public MoveStudentRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public MoveStudentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public MoveStudentRequest setOriginClassId(Long originClassId) {
        this.originClassId = originClassId;
        return this;
    }
    public Long getOriginClassId() {
        return this.originClassId;
    }

    public MoveStudentRequest setTargetClassId(Long targetClassId) {
        this.targetClassId = targetClassId;
        return this;
    }
    public Long getTargetClassId() {
        return this.targetClassId;
    }

}
