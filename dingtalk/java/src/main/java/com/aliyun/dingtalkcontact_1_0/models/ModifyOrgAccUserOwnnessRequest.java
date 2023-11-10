// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ModifyOrgAccUserOwnnessRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("ownenssType")
    public Long ownenssType;

    @NameInMap("ownnessId")
    public Long ownnessId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("text")
    public String text;

    @NameInMap("userId")
    public String userId;

    public static ModifyOrgAccUserOwnnessRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifyOrgAccUserOwnnessRequest self = new ModifyOrgAccUserOwnnessRequest();
        return TeaModel.build(map, self);
    }

    public ModifyOrgAccUserOwnnessRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ModifyOrgAccUserOwnnessRequest setOwnenssType(Long ownenssType) {
        this.ownenssType = ownenssType;
        return this;
    }
    public Long getOwnenssType() {
        return this.ownenssType;
    }

    public ModifyOrgAccUserOwnnessRequest setOwnnessId(Long ownnessId) {
        this.ownnessId = ownnessId;
        return this;
    }
    public Long getOwnnessId() {
        return this.ownnessId;
    }

    public ModifyOrgAccUserOwnnessRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ModifyOrgAccUserOwnnessRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public ModifyOrgAccUserOwnnessRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
