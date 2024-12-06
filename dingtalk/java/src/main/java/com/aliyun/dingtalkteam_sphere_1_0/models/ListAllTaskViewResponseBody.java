// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class ListAllTaskViewResponseBody extends TeaModel {
    @NameInMap("result")
    public ListAllTaskViewResponseBodyResult result;

    public static ListAllTaskViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAllTaskViewResponseBody self = new ListAllTaskViewResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAllTaskViewResponseBody setResult(ListAllTaskViewResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListAllTaskViewResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListAllTaskViewResponseBodyResultGroupType extends TeaModel {
        @NameInMap("canCreateGroup")
        public Boolean canCreateGroup;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListAllTaskViewResponseBodyResultGroupType build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultGroupType self = new ListAllTaskViewResponseBodyResultGroupType();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultGroupType setCanCreateGroup(Boolean canCreateGroup) {
            this.canCreateGroup = canCreateGroup;
            return this;
        }
        public Boolean getCanCreateGroup() {
            return this.canCreateGroup;
        }

        public ListAllTaskViewResponseBodyResultGroupType setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResultGroupType setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListAllTaskViewResponseBodyResultOrderType extends TeaModel {
        @NameInMap("direction")
        public String direction;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListAllTaskViewResponseBodyResultOrderType build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultOrderType self = new ListAllTaskViewResponseBodyResultOrderType();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultOrderType setDirection(String direction) {
            this.direction = direction;
            return this;
        }
        public String getDirection() {
            return this.direction;
        }

        public ListAllTaskViewResponseBodyResultOrderType setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResultOrderType setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListAllTaskViewResponseBodyResultShowType extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListAllTaskViewResponseBodyResultShowType build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultShowType self = new ListAllTaskViewResponseBodyResultShowType();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultShowType setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResultShowType setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting extends TeaModel {
        @NameInMap("dateType")
        public String dateType;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        public static ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting self = new ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting setDateType(String dateType) {
            this.dateType = dateType;
            return this;
        }
        public String getDateType() {
            return this.dateType;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

    public static class ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes extends TeaModel {
        @NameInMap("canCreateGroup")
        public Boolean canCreateGroup;

        @NameInMap("name")
        public String name;

        @NameInMap("serviceName")
        public String serviceName;

        @NameInMap("setting")
        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting setting;

        @NameInMap("value")
        public String value;

        public static ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes self = new ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes setCanCreateGroup(Boolean canCreateGroup) {
            this.canCreateGroup = canCreateGroup;
            return this;
        }
        public Boolean getCanCreateGroup() {
            return this.canCreateGroup;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes setServiceName(String serviceName) {
            this.serviceName = serviceName;
            return this;
        }
        public String getServiceName() {
            return this.serviceName;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes setSetting(ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting setting) {
            this.setting = setting;
            return this;
        }
        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypesSetting getSetting() {
            return this.setting;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes extends TeaModel {
        @NameInMap("direction")
        public String direction;

        @NameInMap("name")
        public String name;

        @NameInMap("supportDirection")
        public String supportDirection;

        @NameInMap("value")
        public String value;

        public static ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes self = new ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes setDirection(String direction) {
            this.direction = direction;
            return this;
        }
        public String getDirection() {
            return this.direction;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes setSupportDirection(String supportDirection) {
            this.supportDirection = supportDirection;
            return this;
        }
        public String getSupportDirection() {
            return this.supportDirection;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListAllTaskViewResponseBodyResultToolbarInfoShowTypes extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListAllTaskViewResponseBodyResultToolbarInfoShowTypes build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultToolbarInfoShowTypes self = new ListAllTaskViewResponseBodyResultToolbarInfoShowTypes();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoShowTypes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfoShowTypes setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListAllTaskViewResponseBodyResultToolbarInfo extends TeaModel {
        @NameInMap("groupTypes")
        public java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes> groupTypes;

        @NameInMap("orderTypes")
        public java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes> orderTypes;

        @NameInMap("showTypes")
        public java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoShowTypes> showTypes;

        public static ListAllTaskViewResponseBodyResultToolbarInfo build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultToolbarInfo self = new ListAllTaskViewResponseBodyResultToolbarInfo();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultToolbarInfo setGroupTypes(java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes> groupTypes) {
            this.groupTypes = groupTypes;
            return this;
        }
        public java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoGroupTypes> getGroupTypes() {
            return this.groupTypes;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfo setOrderTypes(java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes> orderTypes) {
            this.orderTypes = orderTypes;
            return this;
        }
        public java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoOrderTypes> getOrderTypes() {
            return this.orderTypes;
        }

        public ListAllTaskViewResponseBodyResultToolbarInfo setShowTypes(java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoShowTypes> showTypes) {
            this.showTypes = showTypes;
            return this;
        }
        public java.util.List<ListAllTaskViewResponseBodyResultToolbarInfoShowTypes> getShowTypes() {
            return this.showTypes;
        }

    }

    public static class ListAllTaskViewResponseBodyResultViewSetting extends TeaModel {
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

        public static ListAllTaskViewResponseBodyResultViewSetting build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResultViewSetting self = new ListAllTaskViewResponseBodyResultViewSetting();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResultViewSetting setShowDoneTask(Boolean showDoneTask) {
            this.showDoneTask = showDoneTask;
            return this;
        }
        public Boolean getShowDoneTask() {
            return this.showDoneTask;
        }

        public ListAllTaskViewResponseBodyResultViewSetting setShowSubTask(Boolean showSubTask) {
            this.showSubTask = showSubTask;
            return this;
        }
        public Boolean getShowSubTask() {
            return this.showSubTask;
        }

    }

    public static class ListAllTaskViewResponseBodyResult extends TeaModel {
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
        public ListAllTaskViewResponseBodyResultGroupType groupType;

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
        public ListAllTaskViewResponseBodyResultOrderType orderType;

        /**
         * <strong>example:</strong>
         * <p>6139cd1aba5b128516ec8c86</p>
         */
        @NameInMap("organizationId")
        public String organizationId;

        @NameInMap("showType")
        public ListAllTaskViewResponseBodyResultShowType showType;

        @NameInMap("toolbarInfo")
        public ListAllTaskViewResponseBodyResultToolbarInfo toolbarInfo;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        @NameInMap("viewSetting")
        public ListAllTaskViewResponseBodyResultViewSetting viewSetting;

        public static ListAllTaskViewResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListAllTaskViewResponseBodyResult self = new ListAllTaskViewResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListAllTaskViewResponseBodyResult setBoundToObjectId(String boundToObjectId) {
            this.boundToObjectId = boundToObjectId;
            return this;
        }
        public String getBoundToObjectId() {
            return this.boundToObjectId;
        }

        public ListAllTaskViewResponseBodyResult setBoundToObjectType(String boundToObjectType) {
            this.boundToObjectType = boundToObjectType;
            return this;
        }
        public String getBoundToObjectType() {
            return this.boundToObjectType;
        }

        public ListAllTaskViewResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public ListAllTaskViewResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListAllTaskViewResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListAllTaskViewResponseBodyResult setGroupType(ListAllTaskViewResponseBodyResultGroupType groupType) {
            this.groupType = groupType;
            return this;
        }
        public ListAllTaskViewResponseBodyResultGroupType getGroupType() {
            return this.groupType;
        }

        public ListAllTaskViewResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListAllTaskViewResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public ListAllTaskViewResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllTaskViewResponseBodyResult setOrderType(ListAllTaskViewResponseBodyResultOrderType orderType) {
            this.orderType = orderType;
            return this;
        }
        public ListAllTaskViewResponseBodyResultOrderType getOrderType() {
            return this.orderType;
        }

        public ListAllTaskViewResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public ListAllTaskViewResponseBodyResult setShowType(ListAllTaskViewResponseBodyResultShowType showType) {
            this.showType = showType;
            return this;
        }
        public ListAllTaskViewResponseBodyResultShowType getShowType() {
            return this.showType;
        }

        public ListAllTaskViewResponseBodyResult setToolbarInfo(ListAllTaskViewResponseBodyResultToolbarInfo toolbarInfo) {
            this.toolbarInfo = toolbarInfo;
            return this;
        }
        public ListAllTaskViewResponseBodyResultToolbarInfo getToolbarInfo() {
            return this.toolbarInfo;
        }

        public ListAllTaskViewResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public ListAllTaskViewResponseBodyResult setViewSetting(ListAllTaskViewResponseBodyResultViewSetting viewSetting) {
            this.viewSetting = viewSetting;
            return this;
        }
        public ListAllTaskViewResponseBodyResultViewSetting getViewSetting() {
            return this.viewSetting;
        }

    }

}
