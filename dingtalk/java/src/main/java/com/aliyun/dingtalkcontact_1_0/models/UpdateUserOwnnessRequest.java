// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserOwnnessRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deletedFlag")
    public Integer deletedFlag;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ownenssType")
    public Integer ownenssType;

    /**
     * <p>This parameter is required.</p>
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
