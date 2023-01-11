// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateCloudFeedRequest extends TeaModel {
    /**
     * <p>课程封面Url</p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <p>课程简介</p>
     */
    @NameInMap("intro")
    public String intro;

    /**
     * <p>预计开始的时间戳(未来的时间点)</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>课程标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>创建课程的主播id（staffId）</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>云导播课程资源的url</p>
     */
    @NameInMap("videoUrl")
    public String videoUrl;

    public static CreateCloudFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCloudFeedRequest self = new CreateCloudFeedRequest();
        return TeaModel.build(map, self);
    }

    public CreateCloudFeedRequest setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public CreateCloudFeedRequest setIntro(String intro) {
        this.intro = intro;
        return this;
    }
    public String getIntro() {
        return this.intro;
    }

    public CreateCloudFeedRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateCloudFeedRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateCloudFeedRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateCloudFeedRequest setVideoUrl(String videoUrl) {
        this.videoUrl = videoUrl;
        return this;
    }
    public String getVideoUrl() {
        return this.videoUrl;
    }

}
