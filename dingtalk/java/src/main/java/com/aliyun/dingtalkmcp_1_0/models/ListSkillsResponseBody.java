// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ListSkillsResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<ListSkillsResponseBodyItems> items;

    @NameInMap("page")
    public Integer page;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("total")
    public Integer total;

    public static ListSkillsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSkillsResponseBody self = new ListSkillsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSkillsResponseBody setItems(java.util.List<ListSkillsResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<ListSkillsResponseBodyItems> getItems() {
        return this.items;
    }

    public ListSkillsResponseBody setPage(Integer page) {
        this.page = page;
        return this;
    }
    public Integer getPage() {
        return this.page;
    }

    public ListSkillsResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListSkillsResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public static class ListSkillsResponseBodyItemsCategories extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("displayName")
        public String displayName;

        public static ListSkillsResponseBodyItemsCategories build(java.util.Map<String, ?> map) throws Exception {
            ListSkillsResponseBodyItemsCategories self = new ListSkillsResponseBodyItemsCategories();
            return TeaModel.build(map, self);
        }

        public ListSkillsResponseBodyItemsCategories setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public ListSkillsResponseBodyItemsCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class ListSkillsResponseBodyItems extends TeaModel {
        @NameInMap("categories")
        public java.util.List<ListSkillsResponseBodyItemsCategories> categories;

        @NameInMap("description")
        public String description;

        @NameInMap("detailUrl")
        public String detailUrl;

        @NameInMap("icon")
        public String icon;

        @NameInMap("name")
        public String name;

        @NameInMap("skillId")
        public String skillId;

        public static ListSkillsResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            ListSkillsResponseBodyItems self = new ListSkillsResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public ListSkillsResponseBodyItems setCategories(java.util.List<ListSkillsResponseBodyItemsCategories> categories) {
            this.categories = categories;
            return this;
        }
        public java.util.List<ListSkillsResponseBodyItemsCategories> getCategories() {
            return this.categories;
        }

        public ListSkillsResponseBodyItems setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListSkillsResponseBodyItems setDetailUrl(String detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public String getDetailUrl() {
            return this.detailUrl;
        }

        public ListSkillsResponseBodyItems setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListSkillsResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListSkillsResponseBodyItems setSkillId(String skillId) {
            this.skillId = skillId;
            return this;
        }
        public String getSkillId() {
            return this.skillId;
        }

    }

}
