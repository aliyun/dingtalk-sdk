// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateConversationTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("manageSign")
    public Integer manageSign;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static UpdateConversationTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateConversationTypeRequest self = new UpdateConversationTypeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateConversationTypeRequest setManageSign(Integer manageSign) {
        this.manageSign = manageSign;
        return this;
    }
    public Integer getManageSign() {
        return this.manageSign;
    }

    public UpdateConversationTypeRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
