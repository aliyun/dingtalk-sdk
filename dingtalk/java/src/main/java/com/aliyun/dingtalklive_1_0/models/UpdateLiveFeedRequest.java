// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveFeedRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>http:xxx.png</p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <strong>example:</strong>
     * <p>简介</p>
     */
    @NameInMap("introduction")
    public String introduction;

    /**
     * <strong>example:</strong>
     * <p>1617436058000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1206186351746728</p>
     */
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
