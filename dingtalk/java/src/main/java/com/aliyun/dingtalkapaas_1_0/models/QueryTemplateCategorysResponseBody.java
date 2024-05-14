// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryTemplateCategorysResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("categoryList")
    public java.util.List<QueryTemplateCategorysResponseBodyCategoryList> categoryList;

    @NameInMap("total")
    public String total;

    public static QueryTemplateCategorysResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTemplateCategorysResponseBody self = new QueryTemplateCategorysResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTemplateCategorysResponseBody setCategoryList(java.util.List<QueryTemplateCategorysResponseBodyCategoryList> categoryList) {
        this.categoryList = categoryList;
        return this;
    }
    public java.util.List<QueryTemplateCategorysResponseBodyCategoryList> getCategoryList() {
        return this.categoryList;
    }

    public QueryTemplateCategorysResponseBody setTotal(String total) {
        this.total = total;
        return this;
    }
    public String getTotal() {
        return this.total;
    }

    public static class QueryTemplateCategorysResponseBodyCategoryList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        public static QueryTemplateCategorysResponseBodyCategoryList build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateCategorysResponseBodyCategoryList self = new QueryTemplateCategorysResponseBodyCategoryList();
            return TeaModel.build(map, self);
        }

        public QueryTemplateCategorysResponseBodyCategoryList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryTemplateCategorysResponseBodyCategoryList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
