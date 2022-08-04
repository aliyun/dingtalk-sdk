// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChangeGroupOwnerRequest extends TeaModel {
    // 群主id
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    // 群主类型<2.钉钉 3.C端>
    @NameInMap("groupOwnerType")
    public Integer groupOwnerType;

    // 群id(客联系业务系统内的群id)
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
