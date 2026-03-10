// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusivePopupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("imageMediaId")
    public String imageMediaId;

    @NameInMap("openLink")
    public String openLink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userList")
    public java.util.List<String> userList;

    public static ExclusivePopupRequest build(java.util.Map<String, ?> map) throws Exception {
        ExclusivePopupRequest self = new ExclusivePopupRequest();
        return TeaModel.build(map, self);
    }

    public ExclusivePopupRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ExclusivePopupRequest setImageMediaId(String imageMediaId) {
        this.imageMediaId = imageMediaId;
        return this;
    }
    public String getImageMediaId() {
        return this.imageMediaId;
    }

    public ExclusivePopupRequest setOpenLink(String openLink) {
        this.openLink = openLink;
        return this;
    }
    public String getOpenLink() {
        return this.openLink;
    }

    public ExclusivePopupRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ExclusivePopupRequest setUserList(java.util.List<String> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<String> getUserList() {
        return this.userList;
    }

}
