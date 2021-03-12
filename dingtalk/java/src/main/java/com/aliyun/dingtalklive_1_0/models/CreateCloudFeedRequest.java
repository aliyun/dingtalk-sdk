// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateCloudFeedRequest extends TeaModel {
    // 课程标题
    @NameInMap("title")
    public String title;

    // 课程简介
    @NameInMap("intro")
    public String intro;

    // 创建课程的主播id（staffId）
    @NameInMap("userId")
    public String userId;

    // 预计开始的时间戳(未来的时间点)
    @NameInMap("startTime")
    public Long startTime;

    // 课程封面Url
    @NameInMap("coverUrl")
    public String coverUrl;

    // 云导播课程资源的url
    @NameInMap("videoUrl")
    public String videoUrl;

    public static CreateCloudFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCloudFeedRequest self = new CreateCloudFeedRequest();
        return TeaModel.build(map, self);
    }

    public CreateCloudFeedRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateCloudFeedRequest setIntro(String intro) {
        this.intro = intro;
        return this;
    }
    public String getIntro() {
        return this.intro;
    }

    public CreateCloudFeedRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateCloudFeedRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateCloudFeedRequest setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public CreateCloudFeedRequest setVideoUrl(String videoUrl) {
        this.videoUrl = videoUrl;
        return this;
    }
    public String getVideoUrl() {
        return this.videoUrl;
    }

}
