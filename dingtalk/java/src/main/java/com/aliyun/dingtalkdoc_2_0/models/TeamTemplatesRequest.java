// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TeamTemplatesRequest extends TeaModel {
    @NameInMap("option")
    public TeamTemplatesRequestOption option;

    @NameInMap("operatorId")
    public String operatorId;

    public static TeamTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        TeamTemplatesRequest self = new TeamTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public TeamTemplatesRequest setOption(TeamTemplatesRequestOption option) {
        this.option = option;
        return this;
    }
    public TeamTemplatesRequestOption getOption() {
        return this.option;
    }

    public TeamTemplatesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class TeamTemplatesRequestOption extends TeaModel {
        @NameInMap("excludeWorkspaceIds")
        public java.util.List<String> excludeWorkspaceIds;

        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("platform")
        public String platform;

        @NameInMap("templateTypes")
        public java.util.List<Integer> templateTypes;

        @NameInMap("version")
        public Integer version;

        @NameInMap("workspaceIds")
        public java.util.List<String> workspaceIds;

        public static TeamTemplatesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            TeamTemplatesRequestOption self = new TeamTemplatesRequestOption();
            return TeaModel.build(map, self);
        }

        public TeamTemplatesRequestOption setExcludeWorkspaceIds(java.util.List<String> excludeWorkspaceIds) {
            this.excludeWorkspaceIds = excludeWorkspaceIds;
            return this;
        }
        public java.util.List<String> getExcludeWorkspaceIds() {
            return this.excludeWorkspaceIds;
        }

        public TeamTemplatesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public TeamTemplatesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public TeamTemplatesRequestOption setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public TeamTemplatesRequestOption setTemplateTypes(java.util.List<Integer> templateTypes) {
            this.templateTypes = templateTypes;
            return this;
        }
        public java.util.List<Integer> getTemplateTypes() {
            return this.templateTypes;
        }

        public TeamTemplatesRequestOption setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

        public TeamTemplatesRequestOption setWorkspaceIds(java.util.List<String> workspaceIds) {
            this.workspaceIds = workspaceIds;
            return this;
        }
        public java.util.List<String> getWorkspaceIds() {
            return this.workspaceIds;
        }

    }

}
