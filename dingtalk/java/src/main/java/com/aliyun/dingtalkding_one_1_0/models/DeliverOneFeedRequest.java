// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class DeliverOneFeedRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("coverMediaId")
    public String coverMediaId;

    @NameInMap("expireTime")
    public Long expireTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("summary")
    public String summary;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("videoMediaId")
    public String videoMediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("videoTags")
    public java.util.Map<String, String> videoTags;

    public static DeliverOneFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        DeliverOneFeedRequest self = new DeliverOneFeedRequest();
        return TeaModel.build(map, self);
    }

    public DeliverOneFeedRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public DeliverOneFeedRequest setCoverMediaId(String coverMediaId) {
        this.coverMediaId = coverMediaId;
        return this;
    }
    public String getCoverMediaId() {
        return this.coverMediaId;
    }

    public DeliverOneFeedRequest setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public DeliverOneFeedRequest setSummary(String summary) {
        this.summary = summary;
        return this;
    }
    public String getSummary() {
        return this.summary;
    }

    public DeliverOneFeedRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public DeliverOneFeedRequest setVideoMediaId(String videoMediaId) {
        this.videoMediaId = videoMediaId;
        return this;
    }
    public String getVideoMediaId() {
        return this.videoMediaId;
    }

    public DeliverOneFeedRequest setVideoTags(java.util.Map<String, String> videoTags) {
        this.videoTags = videoTags;
        return this;
    }
    public java.util.Map<String, String> getVideoTags() {
        return this.videoTags;
    }

}
