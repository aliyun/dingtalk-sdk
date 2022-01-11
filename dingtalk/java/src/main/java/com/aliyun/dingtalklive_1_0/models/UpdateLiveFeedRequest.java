// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveFeedRequest extends TeaModel {
    // 封面图url
    @NameInMap("coverUrl")
    public String coverUrl;

    // 课程简介
    @NameInMap("introduction")
    public String introduction;

    // 预计开始时间（毫秒值）（课程必须预告状态才可以修改该项）
    @NameInMap("startTime")
    public Long startTime;

    // 课程标题
    @NameInMap("title")
    public String title;

    // 操作者id（修改者的组织内id）
    @NameInMap("userId")
    public String userId;

    public static UpdateLiveFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveFeedRequest self = new UpdateLiveFeedRequest();
        return TeaModel.build(map, self);
    }

    public UpdateLiveFeedRequest setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public UpdateLiveFeedRequest setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public UpdateLiveFeedRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public UpdateLiveFeedRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateLiveFeedRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
