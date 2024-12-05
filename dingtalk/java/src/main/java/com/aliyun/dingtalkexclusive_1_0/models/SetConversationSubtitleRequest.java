// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationSubtitleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>副标题</p>
     */
    @NameInMap("subtitle")
    public String subtitle;

    /**
     * <strong>example:</strong>
     * <p>#0000FF</p>
     */
    @NameInMap("subtitleColor")
    public String subtitleColor;

    public static SetConversationSubtitleRequest build(java.util.Map<String, ?> map) throws Exception {
        SetConversationSubtitleRequest self = new SetConversationSubtitleRequest();
        return TeaModel.build(map, self);
    }

    public SetConversationSubtitleRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SetConversationSubtitleRequest setSubtitle(String subtitle) {
        this.subtitle = subtitle;
        return this;
    }
    public String getSubtitle() {
        return this.subtitle;
    }

    public SetConversationSubtitleRequest setSubtitleColor(String subtitleColor) {
        this.subtitleColor = subtitleColor;
        return this;
    }
    public String getSubtitleColor() {
        return this.subtitleColor;
    }

}
