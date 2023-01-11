// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserOwnnessRequest extends TeaModel {
    /**
     * <p>删除标记</p>
     */
    @NameInMap("deletedFlag")
    public Integer deletedFlag;

    /**
     * <p>结束时间戳（毫秒）</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>业务标志id</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>状态类型</p>
     */
    @NameInMap("ownenssType")
    public Integer ownenssType;

    /**
     * <p>开始时间戳（毫秒）</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static UpdateUserOwnnessRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserOwnnessRequest self = new UpdateUserOwnnessRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUserOwnnessRequest setDeletedFlag(Integer deletedFlag) {
        this.deletedFlag = deletedFlag;
        return this;
    }
    public Integer getDeletedFlag() {
        return this.deletedFlag;
    }

    public UpdateUserOwnnessRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public UpdateUserOwnnessRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateUserOwnnessRequest setOwnenssType(Integer ownenssType) {
        this.ownenssType = ownenssType;
        return this;
    }
    public Integer getOwnenssType() {
        return this.ownenssType;
    }

    public UpdateUserOwnnessRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
