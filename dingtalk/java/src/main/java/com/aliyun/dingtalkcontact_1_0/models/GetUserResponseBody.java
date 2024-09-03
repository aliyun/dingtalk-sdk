// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserResponseBody extends TeaModel {
    @NameInMap("avatarUrl")
    public String avatarUrl;

    @NameInMap("email")
    public String email;

    @NameInMap("loginEmail")
    public String loginEmail;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("nick")
    public String nick;

    @NameInMap("openId")
    public String openId;

    @NameInMap("stateCode")
    public String stateCode;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("visitor")
    public Boolean visitor;

    public static GetUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserResponseBody self = new GetUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserResponseBody setAvatarUrl(String avatarUrl) {
        this.avatarUrl = avatarUrl;
        return this;
    }
    public String getAvatarUrl() {
        return this.avatarUrl;
    }

    public GetUserResponseBody setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public GetUserResponseBody setLoginEmail(String loginEmail) {
        this.loginEmail = loginEmail;
        return this;
    }
    public String getLoginEmail() {
        return this.loginEmail;
    }

    public GetUserResponseBody setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public GetUserResponseBody setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

    public GetUserResponseBody setOpenId(String openId) {
        this.openId = openId;
        return this;
    }
    public String getOpenId() {
        return this.openId;
    }

    public GetUserResponseBody setStateCode(String stateCode) {
        this.stateCode = stateCode;
        return this;
    }
    public String getStateCode() {
        return this.stateCode;
    }

    public GetUserResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetUserResponseBody setVisitor(Boolean visitor) {
        this.visitor = visitor;
        return this;
    }
    public Boolean getVisitor() {
        return this.visitor;
    }

}
