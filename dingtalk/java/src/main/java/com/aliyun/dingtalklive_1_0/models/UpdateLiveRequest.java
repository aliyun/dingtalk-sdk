// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png">https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png</a></p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <strong>example:</strong>
     * <p>测试直播简介</p>
     */
    @NameInMap("introduction")
    public String introduction;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>4d383876-1ff9-4b73-a057-a8f47b346ecb</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <strong>example:</strong>
     * <p>1659653648000</p>
     */
    @NameInMap("preEndTime")
    public Long preEndTime;

    /**
     * <strong>example:</strong>
     * <p>1659613648000</p>
     */
    @NameInMap("preStartTime")
    public Long preStartTime;

    /**
     * <strong>example:</strong>
     * <p>测试直播</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DC7wZGOSueEEIGOf3WKwWgiEiE</p>
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
