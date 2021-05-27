// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserResponseBody extends TeaModel {
    // 昵称
    @NameInMap("nick")
    public String nick;

    // 头像url
    @NameInMap("avatarUrl")
    public String avatarUrl;

    // 手机号
    @NameInMap("mobile")
    public String mobile;

    // openId
    @NameInMap("openId")
    public String openId;

    // unionId
    @NameInMap("unionId")
    public String unionId;

    // 个人邮箱
    @NameInMap("email")
    public String email;

    // 手机号对应的国家号
    @NameInMap("stateCode")
    public String stateCode;

    public static GetUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserResponseBody self = new GetUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserResponseBody setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public GetUserResponseBody setAvatarUrl(String avatarUrl) {
        this.avatarUrl = avatarUrl;
        return this;
    }
    public String getAvatarUrl() {
        return this.avatarUrl;
    }

    public GetUserResponseBody setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public GetUserResponseBody setOpenId(String openId) {
        this.openId = openId;
        return this;
    }
    public String getOpenId() {
        return this.openId;
    }

    public GetUserResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetUserResponseBody setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public GetUserResponseBody setStateCode(String stateCode) {
        this.stateCode = stateCode;
        return this;
    }
    public String getStateCode() {
        return this.stateCode;
    }

}
