// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoUserInfoResponseBody extends TeaModel {
    /**
     * <p>用户头像链接</p>
     */
    @NameInMap("avatar")
    public String avatar;

    /**
     * <p>微应用免登用户所在企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>微应用免登用户所在企业名称</p>
     */
    @NameInMap("corpName")
    public String corpName;

    /**
     * <p>用户邮箱</p>
     */
    @NameInMap("email")
    public String email;

    /**
     * <p>是否为企业管理员</p>
     */
    @NameInMap("isAdmin")
    public Boolean isAdmin;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>用户名称</p>
     */
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
