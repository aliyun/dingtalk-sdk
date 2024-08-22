// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantScopeResponseBody extends TeaModel {
    @NameInMap("result")
    public RetrieveAssistantScopeResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static RetrieveAssistantScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantScopeResponseBody self = new RetrieveAssistantScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantScopeResponseBody setResult(RetrieveAssistantScopeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RetrieveAssistantScopeResponseBodyResult getResult() {
        return this.result;
    }

    public RetrieveAssistantScopeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RetrieveAssistantScopeResponseBodyResultScopes extends TeaModel {
        @NameInMap("deptVisibleScopes")
        public java.util.List<String> deptVisibleScopes;

        @NameInMap("dynamicGroupScopes")
        public java.util.List<String> dynamicGroupScopes;

        @NameInMap("isAdmin")
        public Boolean isAdmin;

        @NameInMap("roleVisibleScopes")
        public java.util.List<String> roleVisibleScopes;

        @NameInMap("userVisibleScopes")
        public java.util.List<String> userVisibleScopes;

        public static RetrieveAssistantScopeResponseBodyResultScopes build(java.util.Map<String, ?> map) throws Exception {
            RetrieveAssistantScopeResponseBodyResultScopes self = new RetrieveAssistantScopeResponseBodyResultScopes();
            return TeaModel.build(map, self);
        }

        public RetrieveAssistantScopeResponseBodyResultScopes setDeptVisibleScopes(java.util.List<String> deptVisibleScopes) {
            this.deptVisibleScopes = deptVisibleScopes;
            return this;
        }
        public java.util.List<String> getDeptVisibleScopes() {
            return this.deptVisibleScopes;
        }

        public RetrieveAssistantScopeResponseBodyResultScopes setDynamicGroupScopes(java.util.List<String> dynamicGroupScopes) {
            this.dynamicGroupScopes = dynamicGroupScopes;
            return this;
        }
        public java.util.List<String> getDynamicGroupScopes() {
            return this.dynamicGroupScopes;
        }

        public RetrieveAssistantScopeResponseBodyResultScopes setIsAdmin(Boolean isAdmin) {
            this.isAdmin = isAdmin;
            return this;
        }
        public Boolean getIsAdmin() {
            return this.isAdmin;
        }

        public RetrieveAssistantScopeResponseBodyResultScopes setRoleVisibleScopes(java.util.List<String> roleVisibleScopes) {
            this.roleVisibleScopes = roleVisibleScopes;
            return this;
        }
        public java.util.List<String> getRoleVisibleScopes() {
            return this.roleVisibleScopes;
        }

        public RetrieveAssistantScopeResponseBodyResultScopes setUserVisibleScopes(java.util.List<String> userVisibleScopes) {
            this.userVisibleScopes = userVisibleScopes;
            return this;
        }
        public java.util.List<String> getUserVisibleScopes() {
            return this.userVisibleScopes;
        }

    }

    public static class RetrieveAssistantScopeResponseBodyResult extends TeaModel {
        @NameInMap("assistantId")
        public String assistantId;

        @NameInMap("scopes")
        public RetrieveAssistantScopeResponseBodyResultScopes scopes;

        @NameInMap("sharing")
        public Boolean sharing;

        public static RetrieveAssistantScopeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RetrieveAssistantScopeResponseBodyResult self = new RetrieveAssistantScopeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RetrieveAssistantScopeResponseBodyResult setAssistantId(String assistantId) {
            this.assistantId = assistantId;
            return this;
        }
        public String getAssistantId() {
            return this.assistantId;
        }

        public RetrieveAssistantScopeResponseBodyResult setScopes(RetrieveAssistantScopeResponseBodyResultScopes scopes) {
            this.scopes = scopes;
            return this;
        }
        public RetrieveAssistantScopeResponseBodyResultScopes getScopes() {
            return this.scopes;
        }

        public RetrieveAssistantScopeResponseBodyResult setSharing(Boolean sharing) {
            this.sharing = sharing;
            return this;
        }
        public Boolean getSharing() {
            return this.sharing;
        }

    }

}
