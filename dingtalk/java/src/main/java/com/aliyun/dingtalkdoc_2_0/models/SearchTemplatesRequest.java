// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchTemplatesRequest extends TeaModel {
    @NameInMap("option")
    public SearchTemplatesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public SearchTemplatesRequestParam param;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SearchTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchTemplatesRequest self = new SearchTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public SearchTemplatesRequest setOption(SearchTemplatesRequestOption option) {
        this.option = option;
        return this;
    }
    public SearchTemplatesRequestOption getOption() {
        return this.option;
    }

    public SearchTemplatesRequest setParam(SearchTemplatesRequestParam param) {
        this.param = param;
        return this;
    }
    public SearchTemplatesRequestParam getParam() {
        return this.param;
    }

    public SearchTemplatesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SearchTemplatesRequestOption extends TeaModel {
        @NameInMap("excludeWorkspaceIds")
        public java.util.List<String> excludeWorkspaceIds;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <strong>example:</strong>
         * <p>next_token</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <strong>example:</strong>
         * <p>pc</p>
         */
        @NameInMap("platform")
        public String platform;

        @NameInMap("templateTypes")
        public java.util.List<Integer> templateTypes;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("version")
        public Integer version;

        @NameInMap("workspaceIds")
        public java.util.List<String> workspaceIds;

        public static SearchTemplatesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            SearchTemplatesRequestOption self = new SearchTemplatesRequestOption();
            return TeaModel.build(map, self);
        }

        public SearchTemplatesRequestOption setExcludeWorkspaceIds(java.util.List<String> excludeWorkspaceIds) {
            this.excludeWorkspaceIds = excludeWorkspaceIds;
            return this;
        }
        public java.util.List<String> getExcludeWorkspaceIds() {
            return this.excludeWorkspaceIds;
        }

        public SearchTemplatesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public SearchTemplatesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public SearchTemplatesRequestOption setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public SearchTemplatesRequestOption setTemplateTypes(java.util.List<Integer> templateTypes) {
            this.templateTypes = templateTypes;
            return this;
        }
        public java.util.List<Integer> getTemplateTypes() {
            return this.templateTypes;
        }

        public SearchTemplatesRequestOption setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

        public SearchTemplatesRequestOption setWorkspaceIds(java.util.List<String> workspaceIds) {
            this.workspaceIds = workspaceIds;
            return this;
        }
        public java.util.List<String> getWorkspaceIds() {
            return this.workspaceIds;
        }

    }

    public static class SearchTemplatesRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user_template</p>
         */
        @NameInMap("belong")
        public String belong;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>searchName</p>
         */
        @NameInMap("searchName")
        public String searchName;

        public static SearchTemplatesRequestParam build(java.util.Map<String, ?> map) throws Exception {
            SearchTemplatesRequestParam self = new SearchTemplatesRequestParam();
            return TeaModel.build(map, self);
        }

        public SearchTemplatesRequestParam setBelong(String belong) {
            this.belong = belong;
            return this;
        }
        public String getBelong() {
            return this.belong;
        }

        public SearchTemplatesRequestParam setSearchName(String searchName) {
            this.searchName = searchName;
            return this;
        }
        public String getSearchName() {
            return this.searchName;
        }

    }

}
