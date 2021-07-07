// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class AddProfileRequest extends TeaModel {
    // 昵称
    @NameInMap("nick")
    public String nick;

    // 头像mediaId，调用Upload接口获得
    @NameInMap("avatarMediaId")
    public String avatarMediaId;

    // 外部app的账号，格式：xxx@channel格式
    @NameInMap("appUid")
    public String appUid;

    // 手机号
    @NameInMap("mobileNumber")
    public String mobileNumber;

    public static AddProfileRequest build(java.util.Map<String, ?> map) throws Exception {
        AddProfileRequest self = new AddProfileRequest();
        return TeaModel.build(map, self);
    }

    public AddProfileRequest setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public AddProfileRequest setAvatarMediaId(String avatarMediaId) {
        this.avatarMediaId = avatarMediaId;
        return this;
    }
    public String getAvatarMediaId() {
        return this.avatarMediaId;
    }

    public AddProfileRequest setAppUid(String appUid) {
        this.appUid = appUid;
        return this;
    }
    public String getAppUid() {
        return this.appUid;
    }

    public AddProfileRequest setMobileNumber(String mobileNumber) {
        this.mobileNumber = mobileNumber;
        return this;
    }
    public String getMobileNumber() {
        return this.mobileNumber;
    }

}
