// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CirclePostRecordRequest extends TeaModel {
    @NameInMap("direction")
    public Long direction;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("size")
    public Long size;

    @NameInMap("startTime")
    public Long startTime;

    public static CirclePostRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        CirclePostRecordRequest self = new CirclePostRecordRequest();
        return TeaModel.build(map, self);
    }

    public CirclePostRecordRequest setDirection(Long direction) {
        this.direction = direction;
        return this;
    }
    public Long getDirection() {
        return this.direction;
    }

    public CirclePostRecordRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CirclePostRecordRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

    public CirclePostRecordRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
