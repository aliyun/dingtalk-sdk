// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class SendSearchShadeRequest extends TeaModel {
    @NameInMap("content")
    public java.util.Map<String, ?> content;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("userId")
    public String userId;

    public static SendSearchShadeRequest build(java.util.Map<String, ?> map) throws Exception {
        SendSearchShadeRequest self = new SendSearchShadeRequest();
        return TeaModel.build(map, self);
    }

    public SendSearchShadeRequest setContent(java.util.Map<String, ?> content) {
        this.content = content;
        return this;
    }
    public java.util.Map<String, ?> getContent() {
        return this.content;
    }

    public SendSearchShadeRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public SendSearchShadeRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public SendSearchShadeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
