// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoUserInfoResponseBody extends TeaModel {
    @NameInMap("avatar")
    public String avatar;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("corpName")
    public String corpName;

    @NameInMap("email")
    public String email;

    @NameInMap("isAdmin")
    public Boolean isAdmin;

    @NameInMap("userId")
    public String userId;

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
