// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobStatusCodeDictionaryResponseBody extends TeaModel {
    /**
     * <p>code列表</p>
     */
    @NameInMap("content")
    public java.util.List<QueryJobStatusCodeDictionaryResponseBodyContent> content;

    public static QueryJobStatusCodeDictionaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryJobStatusCodeDictionaryResponseBody self = new QueryJobStatusCodeDictionaryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryJobStatusCodeDictionaryResponseBody setContent(java.util.List<QueryJobStatusCodeDictionaryResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryJobStatusCodeDictionaryResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryJobStatusCodeDictionaryResponseBodyContent extends TeaModel {
        /**
         * <p>分类</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>固定字段标识</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>展示名字</p>
         */
        @NameInMap("displayName")
        public String displayName;

        public static QueryJobStatusCodeDictionaryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryJobStatusCodeDictionaryResponseBodyContent self = new QueryJobStatusCodeDictionaryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryJobStatusCodeDictionaryResponseBodyContent setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryJobStatusCodeDictionaryResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryJobStatusCodeDictionaryResponseBodyContent setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

}
