// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtendValuesResponseBody extends TeaModel {
    /**
     * <p>人员列表</p>
     */
    @NameInMap("content")
    public java.util.List<QueryUserExtendValuesResponseBodyContent> content;

    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <p>数据总量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryUserExtendValuesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserExtendValuesResponseBody self = new QueryUserExtendValuesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserExtendValuesResponseBody setContent(java.util.List<QueryUserExtendValuesResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryUserExtendValuesResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryUserExtendValuesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryUserExtendValuesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryUserExtendValuesResponseBodyContent extends TeaModel {
        /**
         * <p>用户code</p>
         */
        @NameInMap("userCode")
        public String userCode;

        /**
         * <p>扩展字段描述</p>
         */
        @NameInMap("userExtendDisplayName")
        public String userExtendDisplayName;

        /**
         * <p>扩展字段key</p>
         */
        @NameInMap("userExtendKey")
        public String userExtendKey;

        /**
         * <p>扩展字段value</p>
         */
        @NameInMap("userExtendValue")
        public String userExtendValue;

        public static QueryUserExtendValuesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserExtendValuesResponseBodyContent self = new QueryUserExtendValuesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserExtendValuesResponseBodyContent setUserCode(String userCode) {
            this.userCode = userCode;
            return this;
        }
        public String getUserCode() {
            return this.userCode;
        }

        public QueryUserExtendValuesResponseBodyContent setUserExtendDisplayName(String userExtendDisplayName) {
            this.userExtendDisplayName = userExtendDisplayName;
            return this;
        }
        public String getUserExtendDisplayName() {
            return this.userExtendDisplayName;
        }

        public QueryUserExtendValuesResponseBodyContent setUserExtendKey(String userExtendKey) {
            this.userExtendKey = userExtendKey;
            return this;
        }
        public String getUserExtendKey() {
            return this.userExtendKey;
        }

        public QueryUserExtendValuesResponseBodyContent setUserExtendValue(String userExtendValue) {
            this.userExtendValue = userExtendValue;
            return this;
        }
        public String getUserExtendValue() {
            return this.userExtendValue;
        }

    }

}
