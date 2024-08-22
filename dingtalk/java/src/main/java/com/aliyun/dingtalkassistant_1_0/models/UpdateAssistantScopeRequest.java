// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class UpdateAssistantScopeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("assistantId")
    public String assistantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("scopes")
    public UpdateAssistantScopeRequestScopes scopes;

    @NameInMap("sharing")
    public Boolean sharing;

    public static UpdateAssistantScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAssistantScopeRequest self = new UpdateAssistantScopeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAssistantScopeRequest setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

    public UpdateAssistantScopeRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public UpdateAssistantScopeRequest setScopes(UpdateAssistantScopeRequestScopes scopes) {
        this.scopes = scopes;
        return this;
    }
    public UpdateAssistantScopeRequestScopes getScopes() {
        return this.scopes;
    }

    public UpdateAssistantScopeRequest setSharing(Boolean sharing) {
        this.sharing = sharing;
        return this;
    }
    public Boolean getSharing() {
        return this.sharing;
    }

    public static class UpdateAssistantScopeRequestScopes extends TeaModel {
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

        public static UpdateAssistantScopeRequestScopes build(java.util.Map<String, ?> map) throws Exception {
            UpdateAssistantScopeRequestScopes self = new UpdateAssistantScopeRequestScopes();
            return TeaModel.build(map, self);
        }

        public UpdateAssistantScopeRequestScopes setDeptVisibleScopes(java.util.List<String> deptVisibleScopes) {
            this.deptVisibleScopes = deptVisibleScopes;
            return this;
        }
        public java.util.List<String> getDeptVisibleScopes() {
            return this.deptVisibleScopes;
        }

        public UpdateAssistantScopeRequestScopes setDynamicGroupScopes(java.util.List<String> dynamicGroupScopes) {
            this.dynamicGroupScopes = dynamicGroupScopes;
            return this;
        }
        public java.util.List<String> getDynamicGroupScopes() {
            return this.dynamicGroupScopes;
        }

        public UpdateAssistantScopeRequestScopes setIsAdmin(Boolean isAdmin) {
            this.isAdmin = isAdmin;
            return this;
        }
        public Boolean getIsAdmin() {
            return this.isAdmin;
        }

        public UpdateAssistantScopeRequestScopes setRoleVisibleScopes(java.util.List<String> roleVisibleScopes) {
            this.roleVisibleScopes = roleVisibleScopes;
            return this;
        }
        public java.util.List<String> getRoleVisibleScopes() {
            return this.roleVisibleScopes;
        }

        public UpdateAssistantScopeRequestScopes setUserVisibleScopes(java.util.List<String> userVisibleScopes) {
            this.userVisibleScopes = userVisibleScopes;
            return this;
        }
        public java.util.List<String> getUserVisibleScopes() {
            return this.userVisibleScopes;
        }

    }

}
