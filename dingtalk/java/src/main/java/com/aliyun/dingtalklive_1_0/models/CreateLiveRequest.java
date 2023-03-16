// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateLiveRequest extends TeaModel {
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
     * <p>直播分享范围 0:不公开 1:全面公开 2:组织内公开</p>
     */
    @NameInMap("publicType")
    public Long publicType;

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
