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

    public static class ListMyShortcutViewsResponseBodyResultFilterConditionsOp extends TeaModel {
        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultFilterConditionsOp build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilterConditionsOp self = new ListMyShortcutViewsResponseBodyResultFilterConditionsOp();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditionsOp setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultFilterConditionsValues extends TeaModel {
        @NameInMap("deep")
        public String deep;

        @NameInMap("id")
        public String id;

        @NameInMap("label")
        public String label;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultFilterConditionsValues build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilterConditionsValues self = new ListMyShortcutViewsResponseBodyResultFilterConditionsValues();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditionsValues setDeep(String deep) {
            this.deep = deep;
            return this;
        }
        public String getDeep() {
            return this.deep;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditionsValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditionsValues setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditionsValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditionsValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultFilterConditions extends TeaModel {
        @NameInMap("fixed")
        public Boolean fixed;

        @NameInMap("key")
        public String key;

        @NameInMap("op")
        public ListMyShortcutViewsResponseBodyResultFilterConditionsOp op;

        @NameInMap("values")
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterConditionsValues> values;

        public static ListMyShortcutViewsResponseBodyResultFilterConditions build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilterConditions self = new ListMyShortcutViewsResponseBodyResultFilterConditions();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditions setFixed(Boolean fixed) {
            this.fixed = fixed;
            return this;
        }
        public Boolean getFixed() {
            return this.fixed;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditions setOp(ListMyShortcutViewsResponseBodyResultFilterConditionsOp op) {
            this.op = op;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultFilterConditionsOp getOp() {
            return this.op;
        }

        public ListMyShortcutViewsResponseBodyResultFilterConditions setValues(java.util.List<ListMyShortcutViewsResponseBodyResultFilterConditionsValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterConditionsValues> getValues() {
            return this.values;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp extends TeaModel {
        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp self = new ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues extends TeaModel {
        @NameInMap("deep")
        public String deep;

        @NameInMap("id")
        public String id;

        @NameInMap("label")
        public String label;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues self = new ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues setDeep(String deep) {
            this.deep = deep;
            return this;
        }
        public String getDeep() {
            return this.deep;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions extends TeaModel {
        @NameInMap("fixed")
        public Boolean fixed;

        @NameInMap("key")
        public String key;

        @NameInMap("op")
        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp op;

        @NameInMap("values")
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues> values;

        public static ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions self = new ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions setFixed(Boolean fixed) {
            this.fixed = fixed;
            return this;
        }
        public Boolean getFixed() {
            return this.fixed;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions setOp(ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp op) {
            this.op = op;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsOp getOp() {
            return this.op;
        }

        public ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions setValues(java.util.List<ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterInvisibleConditionsValues> getValues() {
            return this.values;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultFilter extends TeaModel {
        @NameInMap("conditions")
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterConditions> conditions;

        @NameInMap("invisibleConditions")
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions> invisibleConditions;

        @NameInMap("logic")
        public String logic;

        @NameInMap("logicDisabled")
        public Boolean logicDisabled;

        @NameInMap("q")
        public String q;

        public static ListMyShortcutViewsResponseBodyResultFilter build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultFilter self = new ListMyShortcutViewsResponseBodyResultFilter();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultFilter setConditions(java.util.List<ListMyShortcutViewsResponseBodyResultFilterConditions> conditions) {
            this.conditions = conditions;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterConditions> getConditions() {
            return this.conditions;
        }

        public ListMyShortcutViewsResponseBodyResultFilter setInvisibleConditions(java.util.List<ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions> invisibleConditions) {
            this.invisibleConditions = invisibleConditions;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultFilterInvisibleConditions> getInvisibleConditions() {
            return this.invisibleConditions;
        }

        public ListMyShortcutViewsResponseBodyResultFilter setLogic(String logic) {
            this.logic = logic;
            return this;
        }
        public String getLogic() {
            return this.logic;
        }

        public ListMyShortcutViewsResponseBodyResultFilter setLogicDisabled(Boolean logicDisabled) {
            this.logicDisabled = logicDisabled;
            return this;
        }
        public Boolean getLogicDisabled() {
            return this.logicDisabled;
        }

        public ListMyShortcutViewsResponseBodyResultFilter setQ(String q) {
            this.q = q;
            return this;
        }
        public String getQ() {
            return this.q;
        }

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

    public static class ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting extends TeaModel {
        @NameInMap("dateType")
        public String dateType;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        public static ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting self = new ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting setDateType(String dateType) {
            this.dateType = dateType;
            return this;
        }
        public String getDateType() {
            return this.dateType;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes extends TeaModel {
        @NameInMap("canCreateGroup")
        public Boolean canCreateGroup;

        @NameInMap("name")
        public String name;

        @NameInMap("serviceName")
        public String serviceName;

        @NameInMap("setting")
        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting setting;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes self = new ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes setCanCreateGroup(Boolean canCreateGroup) {
            this.canCreateGroup = canCreateGroup;
            return this;
        }
        public Boolean getCanCreateGroup() {
            return this.canCreateGroup;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes setServiceName(String serviceName) {
            this.serviceName = serviceName;
            return this;
        }
        public String getServiceName() {
            return this.serviceName;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes setSetting(ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting setting) {
            this.setting = setting;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypesSetting getSetting() {
            return this.setting;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes extends TeaModel {
        @NameInMap("direction")
        public String direction;

        @NameInMap("name")
        public String name;

        @NameInMap("supportDirection")
        public String supportDirection;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes self = new ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes setDirection(String direction) {
            this.direction = direction;
            return this;
        }
        public String getDirection() {
            return this.direction;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes setSupportDirection(String supportDirection) {
            this.supportDirection = supportDirection;
            return this;
        }
        public String getSupportDirection() {
            return this.supportDirection;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes self = new ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListMyShortcutViewsResponseBodyResultToolbarInfo extends TeaModel {
        @NameInMap("groupTypes")
        public java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes> groupTypes;

        @NameInMap("orderTypes")
        public java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes> orderTypes;

        @NameInMap("showTypes")
        public java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes> showTypes;

        public static ListMyShortcutViewsResponseBodyResultToolbarInfo build(java.util.Map<String, ?> map) throws Exception {
            ListMyShortcutViewsResponseBodyResultToolbarInfo self = new ListMyShortcutViewsResponseBodyResultToolbarInfo();
            return TeaModel.build(map, self);
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfo setGroupTypes(java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes> groupTypes) {
            this.groupTypes = groupTypes;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoGroupTypes> getGroupTypes() {
            return this.groupTypes;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfo setOrderTypes(java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes> orderTypes) {
            this.orderTypes = orderTypes;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoOrderTypes> getOrderTypes() {
            return this.orderTypes;
        }

        public ListMyShortcutViewsResponseBodyResultToolbarInfo setShowTypes(java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes> showTypes) {
            this.showTypes = showTypes;
            return this;
        }
        public java.util.List<ListMyShortcutViewsResponseBodyResultToolbarInfoShowTypes> getShowTypes() {
            return this.showTypes;
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

        @NameInMap("filter")
        public ListMyShortcutViewsResponseBodyResultFilter filter;

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

        @NameInMap("toolbarInfo")
        public ListMyShortcutViewsResponseBodyResultToolbarInfo toolbarInfo;

        @NameInMap("tql")
        public String tql;

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

        public ListMyShortcutViewsResponseBodyResult setFilter(ListMyShortcutViewsResponseBodyResultFilter filter) {
            this.filter = filter;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultFilter getFilter() {
            return this.filter;
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

        public ListMyShortcutViewsResponseBodyResult setToolbarInfo(ListMyShortcutViewsResponseBodyResultToolbarInfo toolbarInfo) {
            this.toolbarInfo = toolbarInfo;
            return this;
        }
        public ListMyShortcutViewsResponseBodyResultToolbarInfo getToolbarInfo() {
            return this.toolbarInfo;
        }

        public ListMyShortcutViewsResponseBodyResult setTql(String tql) {
            this.tql = tql;
            return this;
        }
        public String getTql() {
            return this.tql;
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
