// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtendValuesResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryUserExtendValuesResponseBodyContent> content;

    @NameInMap("success")
    public Boolean success;

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
        @NameInMap("userCode")
        public String userCode;

        @NameInMap("userExtendDisplayName")
        public String userExtendDisplayName;

        @NameInMap("userExtendKey")
        public String userExtendKey;

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
