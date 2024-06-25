// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobCodeDictionaryResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public java.util.List<QueryJobCodeDictionaryResponseBodyContent> content;

    public static QueryJobCodeDictionaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryJobCodeDictionaryResponseBody self = new QueryJobCodeDictionaryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryJobCodeDictionaryResponseBody setContent(java.util.List<QueryJobCodeDictionaryResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryJobCodeDictionaryResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryJobCodeDictionaryResponseBodyContent extends TeaModel {
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

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>医师</p>
         */
        @NameInMap("doctorType")
        public String doctorType;

        public static QueryJobCodeDictionaryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryJobCodeDictionaryResponseBodyContent self = new QueryJobCodeDictionaryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryJobCodeDictionaryResponseBodyContent setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public QueryJobCodeDictionaryResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryJobCodeDictionaryResponseBodyContent setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public QueryJobCodeDictionaryResponseBodyContent setDoctorType(String doctorType) {
            this.doctorType = doctorType;
            return this;
        }
        public String getDoctorType() {
            return this.doctorType;
        }

    }

}
