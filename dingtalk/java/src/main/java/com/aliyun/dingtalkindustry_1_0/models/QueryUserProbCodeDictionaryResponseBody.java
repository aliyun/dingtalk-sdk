// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserProbCodeDictionaryResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryUserProbCodeDictionaryResponseBodyContent> content;

    public static QueryUserProbCodeDictionaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserProbCodeDictionaryResponseBody self = new QueryUserProbCodeDictionaryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserProbCodeDictionaryResponseBody setContent(java.util.List<QueryUserProbCodeDictionaryResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryUserProbCodeDictionaryResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryUserProbCodeDictionaryResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>主任医师</p>
         */
        @NameInMap("displayName")
        public String displayName;

        public static QueryUserProbCodeDictionaryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserProbCodeDictionaryResponseBodyContent self = new QueryUserProbCodeDictionaryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserProbCodeDictionaryResponseBodyContent setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryUserProbCodeDictionaryResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryUserProbCodeDictionaryResponseBodyContent setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

}
