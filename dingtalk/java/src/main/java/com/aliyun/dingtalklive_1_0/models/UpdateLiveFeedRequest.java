// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveFeedRequest extends TeaModel {
    @NameInMap("coverUrl")
    public String coverUrl;

    @NameInMap("introduction")
    public String introduction;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

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
