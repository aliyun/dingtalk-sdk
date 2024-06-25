// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class GrantHonorRequest extends TeaModel {
    @NameInMap("expirationTime")
    public Long expirationTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>表现优秀，特此奖励！</p>
     */
    @NameInMap("grantReason")
    public String grantReason;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>组织文化团队</p>
     */
    @NameInMap("granterName")
    public String granterName;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("noticeAnnouncer")
    public Boolean noticeAnnouncer;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("noticeSingle")
    public Boolean noticeSingle;

    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxUserId</p>
     */
    @NameInMap("senderUserId")
    public String senderUserId;

    public static GrantHonorRequest build(java.util.Map<String, ?> map) throws Exception {
        GrantHonorRequest self = new GrantHonorRequest();
        return TeaModel.build(map, self);
    }

    public GrantHonorRequest setExpirationTime(Long expirationTime) {
        this.expirationTime = expirationTime;
        return this;
    }
    public Long getExpirationTime() {
        return this.expirationTime;
    }

    public GrantHonorRequest setGrantReason(String grantReason) {
        this.grantReason = grantReason;
        return this;
    }
    public String getGrantReason() {
        return this.grantReason;
    }

    public GrantHonorRequest setGranterName(String granterName) {
        this.granterName = granterName;
        return this;
    }
    public String getGranterName() {
        return this.granterName;
    }

    public GrantHonorRequest setNoticeAnnouncer(Boolean noticeAnnouncer) {
        this.noticeAnnouncer = noticeAnnouncer;
        return this;
    }
    public Boolean getNoticeAnnouncer() {
        return this.noticeAnnouncer;
    }

    public GrantHonorRequest setNoticeSingle(Boolean noticeSingle) {
        this.noticeSingle = noticeSingle;
        return this;
    }
    public Boolean getNoticeSingle() {
        return this.noticeSingle;
    }

    public GrantHonorRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

    public GrantHonorRequest setReceiverUserIds(java.util.List<String> receiverUserIds) {
        this.receiverUserIds = receiverUserIds;
        return this;
    }
    public java.util.List<String> getReceiverUserIds() {
        return this.receiverUserIds;
    }

    public GrantHonorRequest setSenderUserId(String senderUserId) {
        this.senderUserId = senderUserId;
        return this;
    }
    public String getSenderUserId() {
        return this.senderUserId;
    }

}
