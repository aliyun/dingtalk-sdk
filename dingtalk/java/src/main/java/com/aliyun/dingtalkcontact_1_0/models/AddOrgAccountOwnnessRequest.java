// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddOrgAccountOwnnessRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("ownenssType")
    public Long ownenssType;

    @NameInMap("ownnessId")
    public Long ownnessId;

    @NameInMap("startTime")
    public Float startTime;

    @NameInMap("text")
    public String text;

    @NameInMap("userId")
    public String userId;

    public static AddOrgAccountOwnnessRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgAccountOwnnessRequest self = new AddOrgAccountOwnnessRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgAccountOwnnessRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public AddOrgAccountOwnnessRequest setOwnenssType(Long ownenssType) {
        this.ownenssType = ownenssType;
        return this;
    }
    public Long getOwnenssType() {
        return this.ownenssType;
    }

    public AddOrgAccountOwnnessRequest setOwnnessId(Long ownnessId) {
        this.ownnessId = ownnessId;
        return this;
    }
    public Long getOwnnessId() {
        return this.ownnessId;
    }

    public AddOrgAccountOwnnessRequest setStartTime(Float startTime) {
        this.startTime = startTime;
        return this;
    }
    public Float getStartTime() {
        return this.startTime;
    }

    public AddOrgAccountOwnnessRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public AddOrgAccountOwnnessRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
