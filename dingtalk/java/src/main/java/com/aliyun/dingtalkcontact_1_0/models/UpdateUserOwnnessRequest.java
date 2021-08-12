// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserOwnnessRequest extends TeaModel {
    // 状态类型
    @NameInMap("ownenssType")
    public Integer ownenssType;

    // 业务标志id
    @NameInMap("id")
    public Long id;

    // 开始时间戳（毫秒）
    @NameInMap("startTime")
    public Long startTime;

    // 结束时间戳（毫秒）
    @NameInMap("endTime")
    public Long endTime;

    // 删除标记
    @NameInMap("deletedFlag")
    public Integer deletedFlag;

    public static UpdateUserOwnnessRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserOwnnessRequest self = new UpdateUserOwnnessRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUserOwnnessRequest setOwnenssType(Integer ownenssType) {
        this.ownenssType = ownenssType;
        return this;
    }
    public Integer getOwnenssType() {
        return this.ownenssType;
    }

    public UpdateUserOwnnessRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateUserOwnnessRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public UpdateUserOwnnessRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public UpdateUserOwnnessRequest setDeletedFlag(Integer deletedFlag) {
        this.deletedFlag = deletedFlag;
        return this;
    }
    public Integer getDeletedFlag() {
        return this.deletedFlag;
    }

}
