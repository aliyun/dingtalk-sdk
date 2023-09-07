// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class SendBannerRequest extends TeaModel {
    @NameInMap("content")
    public java.util.Map<String, ?> content;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("userId")
    public String userId;

    public static SendBannerRequest build(java.util.Map<String, ?> map) throws Exception {
        SendBannerRequest self = new SendBannerRequest();
        return TeaModel.build(map, self);
    }

    public SendBannerRequest setContent(java.util.Map<String, ?> content) {
        this.content = content;
        return this;
    }
    public java.util.Map<String, ?> getContent() {
        return this.content;
    }

    public SendBannerRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public SendBannerRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public SendBannerRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
