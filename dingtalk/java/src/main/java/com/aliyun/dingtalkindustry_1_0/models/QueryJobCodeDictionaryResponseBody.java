// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryJobCodeDictionaryResponseBody extends TeaModel {
    // code列表
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
        // 固定字段标识
        @NameInMap("code")
        public String code;

        // 分类
        @NameInMap("category")
        public String category;

        // 展示名字
        @NameInMap("displayName")
        public String displayName;

        // 1:医师,0:非医师,2:待补充
        @NameInMap("doctorType")
        public String doctorType;

        public static QueryJobCodeDictionaryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryJobCodeDictionaryResponseBodyContent self = new QueryJobCodeDictionaryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryJobCodeDictionaryResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryJobCodeDictionaryResponseBodyContent setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
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
