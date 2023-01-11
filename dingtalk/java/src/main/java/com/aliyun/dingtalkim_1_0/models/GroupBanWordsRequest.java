// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupBanWordsRequest extends TeaModel {
    /**
     * <p>禁言模式</p>
     */
    @NameInMap("banWordsMode")
    public Integer banWordsMode;

    /**
     * <p>开放群id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>扩展参数</p>
     */
    @NameInMap("options")
    public java.util.Map<String, ?> options;

    public static GroupBanWordsRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupBanWordsRequest self = new GroupBanWordsRequest();
        return TeaModel.build(map, self);
    }

    public GroupBanWordsRequest setBanWordsMode(Integer banWordsMode) {
        this.banWordsMode = banWordsMode;
        return this;
    }
    public Integer getBanWordsMode() {
        return this.banWordsMode;
    }

    public GroupBanWordsRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupBanWordsRequest setOptions(java.util.Map<String, ?> options) {
        this.options = options;
        return this;
    }
    public java.util.Map<String, ?> getOptions() {
        return this.options;
    }

}
