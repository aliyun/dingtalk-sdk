// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtendValuesResponseBody extends TeaModel {
    // 人员列表
    @NameInMap("content")
    public java.util.List<QueryUserExtendValuesResponseBodyContent> content;

    // 数据总量
    @NameInMap("totalCount")
    public Long totalCount;

    // 是否成功
    @NameInMap("success")
    public Boolean success;

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

    public QueryUserExtendValuesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryUserExtendValuesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUserExtendValuesResponseBodyContent extends TeaModel {
        // 扩展字段key
        @NameInMap("userExtendKey")
        public String userExtendKey;

        // 扩展字段value
        @NameInMap("userExtendValue")
        public String userExtendValue;

        // 扩展字段描述
        @NameInMap("userExtendDisplayName")
        public String userExtendDisplayName;

        // 用户code
        @NameInMap("userCode")
        public String userCode;

        public static QueryUserExtendValuesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserExtendValuesResponseBodyContent self = new QueryUserExtendValuesResponseBodyContent();
            return TeaModel.build(map, self);
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

        public QueryUserExtendValuesResponseBodyContent setUserExtendDisplayName(String userExtendDisplayName) {
            this.userExtendDisplayName = userExtendDisplayName;
            return this;
        }
        public String getUserExtendDisplayName() {
            return this.userExtendDisplayName;
        }

        public QueryUserExtendValuesResponseBodyContent setUserCode(String userCode) {
            this.userCode = userCode;
            return this;
        }
        public String getUserCode() {
            return this.userCode;
        }

    }

}
