// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateLiveRequest extends TeaModel {
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
     * <p>1659653648000</p>
     */
    @NameInMap("preEndTime")
    public Long preEndTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1659613648000</p>
     */
    @NameInMap("preStartTime")
    public Long preStartTime;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("publicType")
    public Long publicType;

    /**
     * <p>This parameter is required.</p>
     * 
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

    public static CreateLiveRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateLiveRequest self = new CreateLiveRequest();
        return TeaModel.build(map, self);
    }

    public CreateLiveRequest setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public CreateLiveRequest setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public CreateLiveRequest setPreEndTime(Long preEndTime) {
        this.preEndTime = preEndTime;
        return this;
    }
    public Long getPreEndTime() {
        return this.preEndTime;
    }

    public CreateLiveRequest setPreStartTime(Long preStartTime) {
        this.preStartTime = preStartTime;
        return this;
    }
    public Long getPreStartTime() {
        return this.preStartTime;
    }

    public CreateLiveRequest setPublicType(Long publicType) {
        this.publicType = publicType;
        return this;
    }
    public Long getPublicType() {
        return this.publicType;
    }

    public CreateLiveRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateLiveRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
