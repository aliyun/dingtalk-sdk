// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class MoveStudentRequest extends TeaModel {
    // 管理员id
    @NameInMap("operator")
    public String operator;

    // 愿班级id
    @NameInMap("originClassId")
    public Long originClassId;

    // 目标班级id
    @NameInMap("targetClassId")
    public Long targetClassId;

    // 学生id
    @NameInMap("userId")
    public String userId;

    public static MoveStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveStudentRequest self = new MoveStudentRequest();
        return TeaModel.build(map, self);
    }

    public MoveStudentRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
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

    public MoveStudentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
