// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class AddProfileRequest extends TeaModel {
    /**
     * <p>外部app的账号，格式：xxx@channel格式</p>
     */
    @NameInMap("appUid")
    public String appUid;

    /**
     * <p>头像mediaId，调用Upload接口获得</p>
     */
    @NameInMap("avatarMediaId")
    public String avatarMediaId;

    /**
     * <p>手机号</p>
     */
    @NameInMap("mobileNumber")
    public String mobileNumber;

    /**
     * <p>昵称</p>
     */
    @NameInMap("nick")
    public String nick;

    public static AddProfileRequest build(java.util.Map<String, ?> map) throws Exception {
        AddProfileRequest self = new AddProfileRequest();
        return TeaModel.build(map, self);
    }

    public AddProfileRequest setAppUid(String appUid) {
        this.appUid = appUid;
        return this;
    }
    public String getAppUid() {
        return this.appUid;
    }

    public AddProfileRequest setAvatarMediaId(String avatarMediaId) {
        this.avatarMediaId = avatarMediaId;
        return this;
    }
    public String getAvatarMediaId() {
        return this.avatarMediaId;
    }

    public AddProfileRequest setMobileNumber(String mobileNumber) {
        this.mobileNumber = mobileNumber;
        return this;
    }
    public String getMobileNumber() {
        return this.mobileNumber;
    }

    public AddProfileRequest setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

}
