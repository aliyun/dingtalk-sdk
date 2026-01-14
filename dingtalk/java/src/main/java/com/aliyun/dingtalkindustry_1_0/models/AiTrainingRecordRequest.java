// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiTrainingRecordRequest extends TeaModel {
    @NameInMap("direction")
    public Long direction;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("lastId")
    public Long lastId;

    @NameInMap("size")
    public Long size;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("taskId")
    public Long taskId;

    public static AiTrainingRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        AiTrainingRecordRequest self = new AiTrainingRecordRequest();
        return TeaModel.build(map, self);
    }

    public AiTrainingRecordRequest setDirection(Long direction) {
        this.direction = direction;
        return this;
    }
    public Long getDirection() {
        return this.direction;
    }

    public AiTrainingRecordRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public AiTrainingRecordRequest setLastId(Long lastId) {
        this.lastId = lastId;
        return this;
    }
    public Long getLastId() {
        return this.lastId;
    }

    public AiTrainingRecordRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

    public AiTrainingRecordRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public AiTrainingRecordRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
