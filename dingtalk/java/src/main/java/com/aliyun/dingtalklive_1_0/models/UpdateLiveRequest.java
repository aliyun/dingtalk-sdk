// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveRequest extends TeaModel {
    /**
     * <p>直播封面</p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <p>简介</p>
     */
    @NameInMap("introduction")
    public String introduction;

    /**
     * <p>直播id</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>预计结束时间</p>
     */
    @NameInMap("preEndTime")
    public Long preEndTime;

    /**
     * <p>预计开播时间</p>
     */
    @NameInMap("preStartTime")
    public Long preStartTime;

    /**
     * <p>标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>用户id（主播id）</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateLiveRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveRequest self = new UpdateLiveRequest();
        return TeaModel.build(map, self);
    }

    public UpdateLiveRequest setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public UpdateLiveRequest setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public UpdateLiveRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public UpdateLiveRequest setPreEndTime(Long preEndTime) {
        this.preEndTime = preEndTime;
        return this;
    }
    public Long getPreEndTime() {
        return this.preEndTime;
    }

    public UpdateLiveRequest setPreStartTime(Long preStartTime) {
        this.preStartTime = preStartTime;
        return this;
    }
    public Long getPreStartTime() {
        return this.preStartTime;
    }

    public UpdateLiveRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateLiveRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
