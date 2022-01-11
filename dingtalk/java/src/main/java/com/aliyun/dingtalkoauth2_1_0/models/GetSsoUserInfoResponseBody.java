// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoUserInfoResponseBody extends TeaModel {
    // 用户头像链接
    @NameInMap("avatar")
    public String avatar;

    // 微应用免登用户所在企业id
    @NameInMap("corpId")
    public String corpId;

    // 微应用免登用户所在企业名称
    @NameInMap("corpName")
    public String corpName;

    // 用户邮箱
    @NameInMap("email")
    public String email;

    // 是否为企业管理员
    @NameInMap("isAdmin")
    public Boolean isAdmin;

    // 用户id
    @NameInMap("userId")
    public String userId;

    // 用户名称
    @NameInMap("userName")
    public String userName;

    public static GetSsoUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSsoUserInfoResponseBody self = new GetSsoUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSsoUserInfoResponseBody setAvatar(String avatar) {
        this.avatar = avatar;
        return this;
    }
    public String getAvatar() {
        return this.avatar;
    }

    public GetSsoUserInfoResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetSsoUserInfoResponseBody setCorpName(String corpName) {
        this.corpName = corpName;
        return this;
    }
    public String getCorpName() {
        return this.corpName;
    }

    public GetSsoUserInfoResponseBody setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public GetSsoUserInfoResponseBody setIsAdmin(Boolean isAdmin) {
        this.isAdmin = isAdmin;
        return this;
    }
    public Boolean getIsAdmin() {
        return this.isAdmin;
    }

    public GetSsoUserInfoResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetSsoUserInfoResponseBody setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

}
