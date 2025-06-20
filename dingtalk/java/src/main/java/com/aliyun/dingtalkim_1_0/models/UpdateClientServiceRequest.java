// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateClientServiceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>https://***.png</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("resetAvatar")
    public Boolean resetAvatar;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("resetUserName")
    public Boolean resetUserName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    /**
     * <strong>example:</strong>
     * <p>test</p>
     */
    @NameInMap("userName")
    public String userName;

    public static UpdateClientServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateClientServiceRequest self = new UpdateClientServiceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateClientServiceRequest setAvatarUrl(String avatarUrl) {
        this.avatarUrl = avatarUrl;
        return this;
    }
    public String getAvatarUrl() {
        return this.avatarUrl;
    }

    public UpdateClientServiceRequest setResetAvatar(Boolean resetAvatar) {
        this.resetAvatar = resetAvatar;
        return this;
    }
    public Boolean getResetAvatar() {
        return this.resetAvatar;
    }

    public UpdateClientServiceRequest setResetUserName(Boolean resetUserName) {
        this.resetUserName = resetUserName;
        return this;
    }
    public Boolean getResetUserName() {
        return this.resetUserName;
    }

    public UpdateClientServiceRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public UpdateClientServiceRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

}
