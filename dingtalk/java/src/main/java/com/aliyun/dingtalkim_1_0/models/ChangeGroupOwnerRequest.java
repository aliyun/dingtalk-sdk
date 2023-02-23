// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChangeGroupOwnerRequest extends TeaModel {
    /**
     * <p>群主在业务系统内的唯一标识</p>
     */
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    /**
     * <p>群主类型<2.钉内用户类型 3.钉外用户类型></p>
     */
    @NameInMap("groupOwnerType")
    public Integer groupOwnerType;

    /**
     * <p>群会话Id。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static ChangeGroupOwnerRequest build(java.util.Map<String, ?> map) throws Exception {
        ChangeGroupOwnerRequest self = new ChangeGroupOwnerRequest();
        return TeaModel.build(map, self);
    }

    public ChangeGroupOwnerRequest setGroupOwnerId(String groupOwnerId) {
        this.groupOwnerId = groupOwnerId;
        return this;
    }
    public String getGroupOwnerId() {
        return this.groupOwnerId;
    }

    public ChangeGroupOwnerRequest setGroupOwnerType(Integer groupOwnerType) {
        this.groupOwnerType = groupOwnerType;
        return this;
    }
    public Integer getGroupOwnerType() {
        return this.groupOwnerType;
    }

    public ChangeGroupOwnerRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
