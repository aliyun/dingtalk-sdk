// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendPhoneDingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>开会</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userids")
    public java.util.List<String> userids;

    public static SendPhoneDingRequest build(java.util.Map<String, ?> map) throws Exception {
        SendPhoneDingRequest self = new SendPhoneDingRequest();
        return TeaModel.build(map, self);
    }

    public SendPhoneDingRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SendPhoneDingRequest setUserids(java.util.List<String> userids) {
        this.userids = userids;
        return this;
    }
    public java.util.List<String> getUserids() {
        return this.userids;
    }

}
