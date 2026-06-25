// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ListMarketMcpsResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<ListMarketMcpsResponseBodyItems> items;

    @NameInMap("page")
    public Integer page;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("total")
    public Integer total;

    public static ListMarketMcpsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMarketMcpsResponseBody self = new ListMarketMcpsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMarketMcpsResponseBody setItems(java.util.List<ListMarketMcpsResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<ListMarketMcpsResponseBodyItems> getItems() {
        return this.items;
    }

    public ListMarketMcpsResponseBody setPage(Integer page) {
        this.page = page;
        return this;
    }
    public Integer getPage() {
        return this.page;
    }

    public ListMarketMcpsResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListMarketMcpsResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public static class ListMarketMcpsResponseBodyItemsCategories extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("displayName")
        public String displayName;

        public static ListMarketMcpsResponseBodyItemsCategories build(java.util.Map<String, ?> map) throws Exception {
            ListMarketMcpsResponseBodyItemsCategories self = new ListMarketMcpsResponseBodyItemsCategories();
            return TeaModel.build(map, self);
        }

        public ListMarketMcpsResponseBodyItemsCategories setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public ListMarketMcpsResponseBodyItemsCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class ListMarketMcpsResponseBodyItems extends TeaModel {
        @NameInMap("categories")
        public java.util.List<ListMarketMcpsResponseBodyItemsCategories> categories;

        @NameInMap("charged")
        public Boolean charged;

        @NameInMap("description")
        public String description;

        @NameInMap("detailUrl")
        public String detailUrl;

        @NameInMap("icon")
        public String icon;

        @NameInMap("mcpId")
        public String mcpId;

        @NameInMap("name")
        public String name;

        public static ListMarketMcpsResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            ListMarketMcpsResponseBodyItems self = new ListMarketMcpsResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public ListMarketMcpsResponseBodyItems setCategories(java.util.List<ListMarketMcpsResponseBodyItemsCategories> categories) {
            this.categories = categories;
            return this;
        }
        public java.util.List<ListMarketMcpsResponseBodyItemsCategories> getCategories() {
            return this.categories;
        }

        public ListMarketMcpsResponseBodyItems setCharged(Boolean charged) {
            this.charged = charged;
            return this;
        }
        public Boolean getCharged() {
            return this.charged;
        }

        public ListMarketMcpsResponseBodyItems setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListMarketMcpsResponseBodyItems setDetailUrl(String detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public String getDetailUrl() {
            return this.detailUrl;
        }

        public ListMarketMcpsResponseBodyItems setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListMarketMcpsResponseBodyItems setMcpId(String mcpId) {
            this.mcpId = mcpId;
            return this;
        }
        public String getMcpId() {
            return this.mcpId;
        }

        public ListMarketMcpsResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
