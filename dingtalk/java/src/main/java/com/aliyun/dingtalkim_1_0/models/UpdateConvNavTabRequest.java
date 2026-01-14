// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateConvNavTabRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("mobileUrl")
    public String mobileUrl;

    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("pcUrl")
    public String pcUrl;

    /**
     * <strong>example:</strong>
     * <p>409021</p>
     */
    @NameInMap("tabId")
    public String tabId;

    /**
     * <strong>example:</strong>
     * <p>示例标签页</p>
     */
    @NameInMap("title")
    public String title;

    @NameInMap("userEditable")
    public Boolean userEditable;

    public static UpdateConvNavTabRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateConvNavTabRequest self = new UpdateConvNavTabRequest();
        return TeaModel.build(map, self);
    }

    public UpdateConvNavTabRequest setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public UpdateConvNavTabRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateConvNavTabRequest setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public UpdateConvNavTabRequest setTabId(String tabId) {
        this.tabId = tabId;
        return this;
    }
    public String getTabId() {
        return this.tabId;
    }

    public UpdateConvNavTabRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateConvNavTabRequest setUserEditable(Boolean userEditable) {
        this.userEditable = userEditable;
        return this;
    }
    public Boolean getUserEditable() {
        return this.userEditable;
    }

}
