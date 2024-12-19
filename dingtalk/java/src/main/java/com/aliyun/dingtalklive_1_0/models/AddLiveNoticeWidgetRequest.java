// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveNoticeWidgetRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("iconUrl")
    public String iconUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("jumpUrl")
    public String jumpUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("noticeText")
    public String noticeText;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddLiveNoticeWidgetRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLiveNoticeWidgetRequest self = new AddLiveNoticeWidgetRequest();
        return TeaModel.build(map, self);
    }

    public AddLiveNoticeWidgetRequest setIconUrl(String iconUrl) {
        this.iconUrl = iconUrl;
        return this;
    }
    public String getIconUrl() {
        return this.iconUrl;
    }

    public AddLiveNoticeWidgetRequest setJumpUrl(String jumpUrl) {
        this.jumpUrl = jumpUrl;
        return this;
    }
    public String getJumpUrl() {
        return this.jumpUrl;
    }

    public AddLiveNoticeWidgetRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public AddLiveNoticeWidgetRequest setNoticeText(String noticeText) {
        this.noticeText = noticeText;
        return this;
    }
    public String getNoticeText() {
        return this.noticeText;
    }

    public AddLiveNoticeWidgetRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
