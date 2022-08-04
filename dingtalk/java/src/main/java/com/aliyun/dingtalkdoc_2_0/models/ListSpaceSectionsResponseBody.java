// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListSpaceSectionsResponseBody extends TeaModel {
    // 空间分组列表。
    @NameInMap("items")
    public java.util.List<ListSpaceSectionsResponseBodyItems> items;

    public static ListSpaceSectionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSpaceSectionsResponseBody self = new ListSpaceSectionsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSpaceSectionsResponseBody setItems(java.util.List<ListSpaceSectionsResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<ListSpaceSectionsResponseBodyItems> getItems() {
        return this.items;
    }

    public static class ListSpaceSectionsResponseBodyItems extends TeaModel {
        // 展示类型。
        @NameInMap("displayType")
        public String displayType;

        // 分组id。
        @NameInMap("id")
        public String id;

        // 分组名称。
        @NameInMap("name")
        public String name;

        // 知识库数量。
        @NameInMap("spaceNum")
        public Integer spaceNum;

        // 知识库列表
        @NameInMap("spaces")
        public java.util.List<SpaceModel> spaces;

        public static ListSpaceSectionsResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            ListSpaceSectionsResponseBodyItems self = new ListSpaceSectionsResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public ListSpaceSectionsResponseBodyItems setDisplayType(String displayType) {
            this.displayType = displayType;
            return this;
        }
        public String getDisplayType() {
            return this.displayType;
        }

        public ListSpaceSectionsResponseBodyItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListSpaceSectionsResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListSpaceSectionsResponseBodyItems setSpaceNum(Integer spaceNum) {
            this.spaceNum = spaceNum;
            return this;
        }
        public Integer getSpaceNum() {
            return this.spaceNum;
        }

        public ListSpaceSectionsResponseBodyItems setSpaces(java.util.List<SpaceModel> spaces) {
            this.spaces = spaces;
            return this;
        }
        public java.util.List<SpaceModel> getSpaces() {
            return this.spaces;
        }

    }

}
