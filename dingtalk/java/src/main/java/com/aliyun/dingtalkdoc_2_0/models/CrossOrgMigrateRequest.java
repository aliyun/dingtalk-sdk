// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CrossOrgMigrateRequest extends TeaModel {
    @NameInMap("option")
    public CrossOrgMigrateRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public CrossOrgMigrateRequestParam param;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CrossOrgMigrateRequest build(java.util.Map<String, ?> map) throws Exception {
        CrossOrgMigrateRequest self = new CrossOrgMigrateRequest();
        return TeaModel.build(map, self);
    }

    public CrossOrgMigrateRequest setOption(CrossOrgMigrateRequestOption option) {
        this.option = option;
        return this;
    }
    public CrossOrgMigrateRequestOption getOption() {
        return this.option;
    }

    public CrossOrgMigrateRequest setParam(CrossOrgMigrateRequestParam param) {
        this.param = param;
        return this;
    }
    public CrossOrgMigrateRequestParam getParam() {
        return this.param;
    }

    public CrossOrgMigrateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CrossOrgMigrateRequestOption extends TeaModel {
        @NameInMap("checkOperatorSourceRole")
        public Boolean checkOperatorSourceRole;

        @NameInMap("deleteSource")
        public Boolean deleteSource;

        @NameInMap("needRecycleFailedWorkspaceId")
        public Boolean needRecycleFailedWorkspaceId;

        @NameInMap("relateTeamId")
        public Long relateTeamId;

        @NameInMap("relateTeamIdStr")
        public String relateTeamIdStr;

        @NameInMap("retainOrgGroup")
        public Boolean retainOrgGroup;

        @NameInMap("skipRole")
        public Boolean skipRole;

        @NameInMap("workspaceIdStrs")
        public java.util.List<String> workspaceIdStrs;

        @NameInMap("workspaceIds")
        public java.util.List<Long> workspaceIds;

        public static CrossOrgMigrateRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CrossOrgMigrateRequestOption self = new CrossOrgMigrateRequestOption();
            return TeaModel.build(map, self);
        }

        public CrossOrgMigrateRequestOption setCheckOperatorSourceRole(Boolean checkOperatorSourceRole) {
            this.checkOperatorSourceRole = checkOperatorSourceRole;
            return this;
        }
        public Boolean getCheckOperatorSourceRole() {
            return this.checkOperatorSourceRole;
        }

        public CrossOrgMigrateRequestOption setDeleteSource(Boolean deleteSource) {
            this.deleteSource = deleteSource;
            return this;
        }
        public Boolean getDeleteSource() {
            return this.deleteSource;
        }

        public CrossOrgMigrateRequestOption setNeedRecycleFailedWorkspaceId(Boolean needRecycleFailedWorkspaceId) {
            this.needRecycleFailedWorkspaceId = needRecycleFailedWorkspaceId;
            return this;
        }
        public Boolean getNeedRecycleFailedWorkspaceId() {
            return this.needRecycleFailedWorkspaceId;
        }

        public CrossOrgMigrateRequestOption setRelateTeamId(Long relateTeamId) {
            this.relateTeamId = relateTeamId;
            return this;
        }
        public Long getRelateTeamId() {
            return this.relateTeamId;
        }

        public CrossOrgMigrateRequestOption setRelateTeamIdStr(String relateTeamIdStr) {
            this.relateTeamIdStr = relateTeamIdStr;
            return this;
        }
        public String getRelateTeamIdStr() {
            return this.relateTeamIdStr;
        }

        public CrossOrgMigrateRequestOption setRetainOrgGroup(Boolean retainOrgGroup) {
            this.retainOrgGroup = retainOrgGroup;
            return this;
        }
        public Boolean getRetainOrgGroup() {
            return this.retainOrgGroup;
        }

        public CrossOrgMigrateRequestOption setSkipRole(Boolean skipRole) {
            this.skipRole = skipRole;
            return this;
        }
        public Boolean getSkipRole() {
            return this.skipRole;
        }

        public CrossOrgMigrateRequestOption setWorkspaceIdStrs(java.util.List<String> workspaceIdStrs) {
            this.workspaceIdStrs = workspaceIdStrs;
            return this;
        }
        public java.util.List<String> getWorkspaceIdStrs() {
            return this.workspaceIdStrs;
        }

        public CrossOrgMigrateRequestOption setWorkspaceIds(java.util.List<Long> workspaceIds) {
            this.workspaceIds = workspaceIds;
            return this;
        }
        public java.util.List<Long> getWorkspaceIds() {
            return this.workspaceIds;
        }

    }

    public static class CrossOrgMigrateRequestParam extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        public static CrossOrgMigrateRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CrossOrgMigrateRequestParam self = new CrossOrgMigrateRequestParam();
            return TeaModel.build(map, self);
        }

        public CrossOrgMigrateRequestParam setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

}
