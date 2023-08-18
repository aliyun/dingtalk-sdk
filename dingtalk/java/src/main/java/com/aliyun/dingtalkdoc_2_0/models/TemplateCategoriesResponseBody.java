// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TemplateCategoriesResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<TemplateCategoriesResponseBodyList> list;

    public static TemplateCategoriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TemplateCategoriesResponseBody self = new TemplateCategoriesResponseBody();
        return TeaModel.build(map, self);
    }

    public TemplateCategoriesResponseBody setList(java.util.List<TemplateCategoriesResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<TemplateCategoriesResponseBodyList> getList() {
        return this.list;
    }

    public static class TemplateCategoriesResponseBodyList extends TeaModel {
        @NameInMap("categoryId")
        public String categoryId;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("sort")
        public String sort;

        public static TemplateCategoriesResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            TemplateCategoriesResponseBodyList self = new TemplateCategoriesResponseBodyList();
            return TeaModel.build(map, self);
        }

        public TemplateCategoriesResponseBodyList setCategoryId(String categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public String getCategoryId() {
            return this.categoryId;
        }

        public TemplateCategoriesResponseBodyList setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public TemplateCategoriesResponseBodyList setSort(String sort) {
            this.sort = sort;
            return this;
        }
        public String getSort() {
            return this.sort;
        }

    }

}
