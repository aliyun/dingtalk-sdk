// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupConversationRequest extends TeaModel {
    /**
     * <p>钉外账号在业务系统内的唯一标识。</p>
     */
    @NameInMap("appUserId")
    public String appUserId;

    /**
     * <p>群头像地址。</p>
     */
    @NameInMap("groupAvatar")
    public String groupAvatar;

    /**
     * <p>群名称。</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>群主在业务系统内的唯一标识</p>
     */
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    /**
     * <p>群模板Id。</p>
     */
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <p>操作者在业务系统内的唯一标识。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateCoupleGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupConversationRequest self = new CreateCoupleGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupConversationRequest setAppUserId(String appUserId) {
        this.appUserId = appUserId;
        return this;
    }
    public String getAppUserId() {
        return this.appUserId;
    }

    public CreateCoupleGroupConversationRequest setGroupAvatar(String groupAvatar) {
        this.groupAvatar = groupAvatar;
        return this;
    }
    public String getGroupAvatar() {
        return this.groupAvatar;
    }

    public CreateCoupleGroupConversationRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateCoupleGroupConversationRequest setGroupOwnerId(String groupOwnerId) {
        this.groupOwnerId = groupOwnerId;
        return this;
    }
    public String getGroupOwnerId() {
        return this.groupOwnerId;
    }

    public CreateCoupleGroupConversationRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateCoupleGroupConversationRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
