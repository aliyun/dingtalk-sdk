// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateAclsRequest extends TeaModel {
    // 对日历的访问权限
    @NameInMap("privilege")
    public String privilege;

    // 权限范围
    @NameInMap("scope")
    public CreateAclsRequestScope scope;

    // 是否向授权人发消息
    @NameInMap("sendMsg")
    public Boolean sendMsg;

    public static CreateAclsRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAclsRequest self = new CreateAclsRequest();
        return TeaModel.build(map, self);
    }

    public CreateAclsRequest setPrivilege(String privilege) {
        this.privilege = privilege;
        return this;
    }
    public String getPrivilege() {
        return this.privilege;
    }

    public CreateAclsRequest setScope(CreateAclsRequestScope scope) {
        this.scope = scope;
        return this;
    }
    public CreateAclsRequestScope getScope() {
        return this.scope;
    }

    public CreateAclsRequest setSendMsg(Boolean sendMsg) {
        this.sendMsg = sendMsg;
        return this;
    }
    public Boolean getSendMsg() {
        return this.sendMsg;
    }

    public static class CreateAclsRequestScope extends TeaModel {
        // 权限类型
        @NameInMap("scopeType")
        public String scopeType;

        // 用户id
        @NameInMap("userId")
        public String userId;

        public static CreateAclsRequestScope build(java.util.Map<String, ?> map) throws Exception {
            CreateAclsRequestScope self = new CreateAclsRequestScope();
            return TeaModel.build(map, self);
        }

        public CreateAclsRequestScope setScopeType(String scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public String getScopeType() {
            return this.scopeType;
        }

        public CreateAclsRequestScope setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
