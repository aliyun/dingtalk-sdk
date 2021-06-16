// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtInfoResponseBody extends TeaModel {
    // 扩展属性
    @NameInMap("content")
    public java.util.List<QueryUserExtInfoResponseBodyContent> content;

    public static QueryUserExtInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserExtInfoResponseBody self = new QueryUserExtInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserExtInfoResponseBody setContent(java.util.List<QueryUserExtInfoResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryUserExtInfoResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryUserExtInfoResponseBodyContent extends TeaModel {
        // 扩展属性Key
        @NameInMap("userExtendKey")
        public String userExtendKey;

        // 扩展属性值
        @NameInMap("userExtendValue")
        public String userExtendValue;

        // 扩展属性描述
        @NameInMap("userExtendDisplayName")
        public String userExtendDisplayName;

        public static QueryUserExtInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserExtInfoResponseBodyContent self = new QueryUserExtInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserExtInfoResponseBodyContent setUserExtendKey(String userExtendKey) {
            this.userExtendKey = userExtendKey;
            return this;
        }
        public String getUserExtendKey() {
            return this.userExtendKey;
        }

        public QueryUserExtInfoResponseBodyContent setUserExtendValue(String userExtendValue) {
            this.userExtendValue = userExtendValue;
            return this;
        }
        public String getUserExtendValue() {
            return this.userExtendValue;
        }

        public QueryUserExtInfoResponseBodyContent setUserExtendDisplayName(String userExtendDisplayName) {
            this.userExtendDisplayName = userExtendDisplayName;
            return this;
        }
        public String getUserExtendDisplayName() {
            return this.userExtendDisplayName;
        }

    }

}
