// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UserTemplatesRequest extends TeaModel {
    @NameInMap("option")
    public UserTemplatesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UserTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        UserTemplatesRequest self = new UserTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public UserTemplatesRequest setOption(UserTemplatesRequestOption option) {
        this.option = option;
        return this;
    }
    public UserTemplatesRequestOption getOption() {
        return this.option;
    }

    public UserTemplatesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UserTemplatesRequestOption extends TeaModel {
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

        public static UserTemplatesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            UserTemplatesRequestOption self = new UserTemplatesRequestOption();
            return TeaModel.build(map, self);
        }

        public UserTemplatesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public UserTemplatesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public UserTemplatesRequestOption setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public UserTemplatesRequestOption setTemplateTypes(java.util.List<Integer> templateTypes) {
            this.templateTypes = templateTypes;
            return this;
        }
        public java.util.List<Integer> getTemplateTypes() {
            return this.templateTypes;
        }

        public UserTemplatesRequestOption setVersion(Integer version) {
            this.version = version;
            return this;
        }
        public Integer getVersion() {
            return this.version;
        }

    }

}
