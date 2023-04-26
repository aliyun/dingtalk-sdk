// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateAclsRequest extends TeaModel {
    @NameInMap("privilege")
    public String privilege;

    @NameInMap("scope")
    public CreateAclsRequestScope scope;

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
        @NameInMap("scopeType")
        public String scopeType;

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
