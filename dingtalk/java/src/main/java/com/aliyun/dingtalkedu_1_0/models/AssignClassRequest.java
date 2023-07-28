// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AssignClassRequest extends TeaModel {
    @NameInMap("classId")
    public Long classId;

    @NameInMap("isFinish")
    public Boolean isFinish;

    @NameInMap("operator")
    public String operator;

    @NameInMap("studentId")
    public Long studentId;

    @NameInMap("taskId")
    public Long taskId;

    public static AssignClassRequest build(java.util.Map<String, ?> map) throws Exception {
        AssignClassRequest self = new AssignClassRequest();
        return TeaModel.build(map, self);
    }

    public AssignClassRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public AssignClassRequest setIsFinish(Boolean isFinish) {
        this.isFinish = isFinish;
        return this;
    }
    public Boolean getIsFinish() {
        return this.isFinish;
    }

    public AssignClassRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public AssignClassRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public AssignClassRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
