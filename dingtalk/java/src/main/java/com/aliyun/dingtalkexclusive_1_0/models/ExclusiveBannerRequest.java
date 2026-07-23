// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusiveBannerRequest extends TeaModel {
    @NameInMap("allOrg")
    public Boolean allOrg;

    @NameInMap("duration")
    public Long duration;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("imageMediaId")
    public String imageMediaId;

    @NameInMap("openLink")
    public String openLink;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("userList")
    public java.util.List<String> userList;

    public static ExclusiveBannerRequest build(java.util.Map<String, ?> map) throws Exception {
        ExclusiveBannerRequest self = new ExclusiveBannerRequest();
        return TeaModel.build(map, self);
    }

    public ExclusiveBannerRequest setAllOrg(Boolean allOrg) {
        this.allOrg = allOrg;
        return this;
    }
    public Boolean getAllOrg() {
        return this.allOrg;
    }

    public ExclusiveBannerRequest setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public ExclusiveBannerRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ExclusiveBannerRequest setImageMediaId(String imageMediaId) {
        this.imageMediaId = imageMediaId;
        return this;
    }
    public String getImageMediaId() {
        return this.imageMediaId;
    }

    public ExclusiveBannerRequest setOpenLink(String openLink) {
        this.openLink = openLink;
        return this;
    }
    public String getOpenLink() {
        return this.openLink;
    }

    public ExclusiveBannerRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ExclusiveBannerRequest setUserList(java.util.List<String> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<String> getUserList() {
        return this.userList;
    }

}
