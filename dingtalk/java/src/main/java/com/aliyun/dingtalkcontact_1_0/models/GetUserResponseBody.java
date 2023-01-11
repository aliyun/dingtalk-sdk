// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserResponseBody extends TeaModel {
    /**
     * <p>头像url</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    /**
     * <p>个人邮箱</p>
     */
    @NameInMap("email")
    public String email;

    /**
     * <p>手机号</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>昵称</p>
     */
    @NameInMap("nick")
    public String nick;

    /**
     * <p>openId</p>
     */
    @NameInMap("openId")
    public String openId;

    /**
     * <p>手机号对应的国家号</p>
     */
    @NameInMap("stateCode")
    public String stateCode;

    /**
     * <p>unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

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

}
