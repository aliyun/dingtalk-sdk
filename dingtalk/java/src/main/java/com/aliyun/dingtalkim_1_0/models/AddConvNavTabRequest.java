// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddConvNavTabRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("mobileUrl")
    public String mobileUrl;

    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q==</p>
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
     * <p>示例标签页</p>
     */
    @NameInMap("title")
    public String title;

    @NameInMap("userEditable")
    public Boolean userEditable;

    public static AddConvNavTabRequest build(java.util.Map<String, ?> map) throws Exception {
        AddConvNavTabRequest self = new AddConvNavTabRequest();
        return TeaModel.build(map, self);
    }

    public AddConvNavTabRequest setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public AddConvNavTabRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddConvNavTabRequest setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public AddConvNavTabRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddConvNavTabRequest setUserEditable(Boolean userEditable) {
        this.userEditable = userEditable;
        return this;
    }
    public Boolean getUserEditable() {
        return this.userEditable;
    }

}
