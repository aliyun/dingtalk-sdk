// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class ListMyShortcutViewsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<ListMyShortcutViewsResponseBodyResult> result;

    public static ListMyShortcutViewsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMyShortcutViewsResponseBody self = new ListMyShortcutViewsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMyShortcutViewsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListMyShortcutViewsResponseBody setResult(java.util.List<ListMyShortcutViewsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListMyShortcutViewsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListMyShortcutViewsResponseBodyResultGroupType extends TeaModel {
        @NameInMap("canCreateGroup")
        public Boolean canCreateGroup;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultGroupType build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultGroupType self = new ListMyShortcutViewsResponseBodyResultGroupType();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultGroupType setCanCreateGroup(Boolean canCreateGroup) {
            this.canCreateGroup = canCreateGroup;
            return this;
        }
        public Boolean getCanCreateGroup() {
            return this.canCreateGroup;
        }

        public ListMyShortcutViewsResponseBodyResultGroupType setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultGroupType setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultOrderType extends TeaModel {
        @NameInMap("direction")
        public String direction;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultOrderType build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultOrderType self = new ListMyShortcutViewsResponseBodyResultOrderType();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultOrderType setDirection(String direction) {
            this.direction = direction;
            return this;
        }
        public String getDirection() {
            return this.direction;
        }

        public ListMyShortcutViewsResponseBodyResultOrderType setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultOrderType setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultShowType extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultShowType build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultShowType self = new ListMyShortcutViewsResponseBodyResultShowType();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultShowType setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultShowType setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultViewSetting extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("showDoneTask")
        public Boolean showDoneTask;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("showSubTask")
        public Boolean showSubTask;

        public static ListMyShortcutViewsResponseBodyResultViewSetting build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultViewSetting self = new ListMyShortcutViewsResponseBodyResultViewSetting();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultViewSetting setShowDoneTask(Boolean showDoneTask) {
            this.showDoneTask = showDoneTask;
            return this;
        }
        public Boolean getShowDoneTask() {
            return this.showDoneTask;
        }

        public ListMyShortcutViewsResponseBodyResultViewSetting setShowSubTask(Boolean showSubTask) {
            this.showSubTask = showSubTask;
            return this;
        }
        public Boolean getShowSubTask() {
            return this.showSubTask;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResult extends TeaModel {
        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        /**
         * <strong>example:</strong>
         * <p>user</p>
         */
        @NameInMap("boundToObjectType")
        public String boundToObjectType;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>5f687406f05b283425ea8f6f</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("groupType")
        public ListMyShortcutViewsResponseBodyResultGroupType groupType;

        @NameInMap("id")
        public String id;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p>x项目</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("orderType")
        public ListMyShortcutViewsResponseBodyResultOrderType orderType;

        /**
         * <strong>example:</strong>
         * <p>6139cd1aba5b128516ec8c86</p>
         */
        @NameInMap("organizationId")
        public String organizationId;

        @NameInMap("showType")
        public ListMyShortcutViewsResponseBodyResultShowType showType;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        @NameInMap("viewSetting")
        public ListMyShortcutViewsResponseBodyResultViewSetting viewSetting;

        public static ListMyShortcutViewsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResult self = new ListMyShortcutViewsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResult setBoundToObjectId(String boundToObjectId) {
            this.boundToObjectId = boundToObjectId;
            return this;
        }
        public String getBoundToObjectId() {
            return this.boundToObjectId;
        }

        public ListMyShortcutViewsResponseBodyResult setBoundToObjectType(String boundToObjectType) {
            this.boundToObjectType = boundToObjectType;
            return this;
        }
        public String getBoundToObjectType() {
            return this.boundToObjectType;
        }

        public ListMyShortcutViewsResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public ListMyShortcutViewsResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListMyShortcutViewsResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListMyShortcutViewsResponseBodyResult setGroupType(ListMyShortcutViewsResponseBodyResultGroupType groupType) {
            this.groupType = groupType;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultGroupType getGroupType() {
            return this.groupType;
        }

        public ListMyShortcutViewsResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListMyShortcutViewsResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public ListMyShortcutViewsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResult setOrderType(ListMyShortcutViewsResponseBodyResultOrderType orderType) {
            this.orderType = orderType;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultOrderType getOrderType() {
            return this.orderType;
        }

        public ListMyShortcutViewsResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public ListMyShortcutViewsResponseBodyResult setShowType(ListMyShortcutViewsResponseBodyResultShowType showType) {
            this.showType = showType;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultShowType getShowType() {
            return this.showType;
        }

        public ListMyShortcutViewsResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public ListMyShortcutViewsResponseBodyResult setViewSetting(ListMyShortcutViewsResponseBodyResultViewSetting viewSetting) {
            this.viewSetting = viewSetting;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultViewSetting getViewSetting() {
            return this.viewSetting;
        }

    }

}
