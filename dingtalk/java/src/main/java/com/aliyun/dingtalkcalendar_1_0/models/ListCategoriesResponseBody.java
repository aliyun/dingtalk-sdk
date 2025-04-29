// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListCategoriesResponseBody extends TeaModel {
    @NameInMap("categories")
    public java.util.List<ListCategoriesResponseBodyCategories> categories;

    public static ListCategoriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCategoriesResponseBody self = new ListCategoriesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCategoriesResponseBody setCategories(java.util.List<ListCategoriesResponseBodyCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<ListCategoriesResponseBodyCategories> getCategories() {
        return this.categories;
    }

    public static class ListCategoriesResponseBodyCategories extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("openCategoryId")
        public String openCategoryId;

        public static ListCategoriesResponseBodyCategories build(java.util.Map<String, ?> map) throws Exception {
            ListCategoriesResponseBodyCategories self = new ListCategoriesResponseBodyCategories();
            return TeaModel.build(map, self);
        }

        public ListCategoriesResponseBodyCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public ListCategoriesResponseBodyCategories setOpenCategoryId(String openCategoryId) {
            this.openCategoryId = openCategoryId;
            return this;
        }
        public String getOpenCategoryId() {
            return this.openCategoryId;
        }

    }

}
