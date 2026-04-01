// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListPermissionsRequest extends TeaModel {
    @NameInMap("option")
    public ListPermissionsRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListPermissionsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListPermissionsRequest self = new ListPermissionsRequest();
        return TeaModel.build(map, self);
    }

    public ListPermissionsRequest setOption(ListPermissionsRequestOption option) {
        this.option = option;
        return this;
    }
    public ListPermissionsRequestOption getOption() {
        return this.option;
    }

    public ListPermissionsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class ListPermissionsRequestOption extends TeaModel {
        @NameInMap("filterRoleIds")
        public java.util.List<String> filterRoleIds;

        /**
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <strong>example:</strong>
         * <p>next_token</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        public static ListPermissionsRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListPermissionsRequestOption self = new ListPermissionsRequestOption();
            return TeaModel.build(map, self);
        }

        public ListPermissionsRequestOption setFilterRoleIds(java.util.List<String> filterRoleIds) {
            this.filterRoleIds = filterRoleIds;
            return this;
        }
        public java.util.List<String> getFilterRoleIds() {
            return this.filterRoleIds;
        }

        public ListPermissionsRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListPermissionsRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
