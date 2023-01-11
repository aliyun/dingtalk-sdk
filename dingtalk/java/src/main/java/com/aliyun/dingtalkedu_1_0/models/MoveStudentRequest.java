// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class MoveStudentRequest extends TeaModel {
    /**
     * <p>管理员id</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>愿班级id</p>
     */
    @NameInMap("originClassId")
    public Long originClassId;

    /**
     * <p>目标班级id</p>
     */
    @NameInMap("targetClassId")
    public Long targetClassId;

    /**
     * <p>学生id</p>
     */
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
