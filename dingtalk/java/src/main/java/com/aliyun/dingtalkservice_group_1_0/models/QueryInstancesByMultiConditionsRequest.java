// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryInstancesByMultiConditionsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DING_CUSTOMER</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>888**</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>[     {         &quot;fieldCode&quot;:&quot;contact_name&quot;,         &quot;fieldOperatorType&quot;:&quot;like&quot;,         &quot;value&quot;:&quot;测试api&quot;     } ]</p>
     */
    @NameInMap("searchFields")
    public String searchFields;

    @NameInMap("sortFields")
    public java.util.List<QueryInstancesByMultiConditionsRequestSortFields> sortFields;

    public static QueryInstancesByMultiConditionsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancesByMultiConditionsRequest self = new QueryInstancesByMultiConditionsRequest();
        return TeaModel.build(map, self);
    }

    public QueryInstancesByMultiConditionsRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public QueryInstancesByMultiConditionsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryInstancesByMultiConditionsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryInstancesByMultiConditionsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryInstancesByMultiConditionsRequest setSearchFields(String searchFields) {
        this.searchFields = searchFields;
        return this;
    }
    public String getSearchFields() {
        return this.searchFields;
    }

    public QueryInstancesByMultiConditionsRequest setSortFields(java.util.List<QueryInstancesByMultiConditionsRequestSortFields> sortFields) {
        this.sortFields = sortFields;
        return this;
    }
    public java.util.List<QueryInstancesByMultiConditionsRequestSortFields> getSortFields() {
        return this.sortFields;
    }

    public static class QueryInstancesByMultiConditionsRequestSortFields extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>gmt_create</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>asc升序；desc降序</p>
         */
        @NameInMap("sortBy")
        public String sortBy;

        public static QueryInstancesByMultiConditionsRequestSortFields build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancesByMultiConditionsRequestSortFields self = new QueryInstancesByMultiConditionsRequestSortFields();
            return TeaModel.build(map, self);
        }

        public QueryInstancesByMultiConditionsRequestSortFields setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public QueryInstancesByMultiConditionsRequestSortFields setSortBy(String sortBy) {
            this.sortBy = sortBy;
            return this;
        }
        public String getSortBy() {
            return this.sortBy;
        }

    }

}
