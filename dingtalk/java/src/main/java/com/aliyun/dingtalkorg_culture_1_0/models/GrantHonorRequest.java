// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class GrantHonorRequest extends TeaModel {
    /**
     * <p>有效期到期时间 时间戳. 会处理成到期那天的23:59:59秒的时间戳</p>
     */
    @NameInMap("expirationTime")
    public Long expirationTime;

    /**
     * <p>颁奖词，最多可以填50字</p>
     */
    @NameInMap("grantReason")
    public String grantReason;

    /**
     * <p>颁奖人名字，最多15个字</p>
     */
    @NameInMap("granterName")
    public String granterName;

    /**
     * <p>是否使用官宣号发送内网动态</p>
     */
    @NameInMap("noticeAnnouncer")
    public Boolean noticeAnnouncer;

    /**
     * <p>是否触达单聊会话通知</p>
     */
    @NameInMap("noticeSingle")
    public Boolean noticeSingle;

    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    /**
     * <p>接受人userId</p>
     */
    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    /**
     * <p>发送人userId</p>
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
