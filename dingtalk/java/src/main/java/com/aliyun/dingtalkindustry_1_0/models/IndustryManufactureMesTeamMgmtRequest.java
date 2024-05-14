// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesTeamMgmtRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    @NameInMap("events")
    public java.util.List<String> events;

    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesTeamMgmtRequestExtendData> extendData;

    @NameInMap("groupConfig")
    public java.util.Map<String, ?> groupConfig;

    @NameInMap("groupPlugins")
    public java.util.List<IndustryManufactureMesTeamMgmtRequestGroupPlugins> groupPlugins;

    @NameInMap("groupType")
    public String groupType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    @NameInMap("leaders")
    public java.util.List<IndustryManufactureMesTeamMgmtRequestLeaders> leaders;

    @NameInMap("members")
    public java.util.List<IndustryManufactureMesTeamMgmtRequestMembers> members;

    @NameInMap("name")
    public String name;

    @NameInMap("processIds")
    public java.util.List<String> processIds;

    @NameInMap("tagKey")
    public String tagKey;

    @NameInMap("tagValues")
    public java.util.List<String> tagValues;

    public static IndustryManufactureMesTeamMgmtRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesTeamMgmtRequest self = new IndustryManufactureMesTeamMgmtRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesTeamMgmtRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesTeamMgmtRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesTeamMgmtRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesTeamMgmtRequest setEvents(java.util.List<String> events) {
        this.events = events;
        return this;
    }
    public java.util.List<String> getEvents() {
        return this.events;
    }

    public IndustryManufactureMesTeamMgmtRequest setExtendData(java.util.List<IndustryManufactureMesTeamMgmtRequestExtendData> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.List<IndustryManufactureMesTeamMgmtRequestExtendData> getExtendData() {
        return this.extendData;
    }

    public IndustryManufactureMesTeamMgmtRequest setGroupConfig(java.util.Map<String, ?> groupConfig) {
        this.groupConfig = groupConfig;
        return this;
    }
    public java.util.Map<String, ?> getGroupConfig() {
        return this.groupConfig;
    }

    public IndustryManufactureMesTeamMgmtRequest setGroupPlugins(java.util.List<IndustryManufactureMesTeamMgmtRequestGroupPlugins> groupPlugins) {
        this.groupPlugins = groupPlugins;
        return this;
    }
    public java.util.List<IndustryManufactureMesTeamMgmtRequestGroupPlugins> getGroupPlugins() {
        return this.groupPlugins;
    }

    public IndustryManufactureMesTeamMgmtRequest setGroupType(String groupType) {
        this.groupType = groupType;
        return this;
    }
    public String getGroupType() {
        return this.groupType;
    }

    public IndustryManufactureMesTeamMgmtRequest setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public IndustryManufactureMesTeamMgmtRequest setLeaders(java.util.List<IndustryManufactureMesTeamMgmtRequestLeaders> leaders) {
        this.leaders = leaders;
        return this;
    }
    public java.util.List<IndustryManufactureMesTeamMgmtRequestLeaders> getLeaders() {
        return this.leaders;
    }

    public IndustryManufactureMesTeamMgmtRequest setMembers(java.util.List<IndustryManufactureMesTeamMgmtRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<IndustryManufactureMesTeamMgmtRequestMembers> getMembers() {
        return this.members;
    }

    public IndustryManufactureMesTeamMgmtRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public IndustryManufactureMesTeamMgmtRequest setProcessIds(java.util.List<String> processIds) {
        this.processIds = processIds;
        return this;
    }
    public java.util.List<String> getProcessIds() {
        return this.processIds;
    }

    public IndustryManufactureMesTeamMgmtRequest setTagKey(String tagKey) {
        this.tagKey = tagKey;
        return this;
    }
    public String getTagKey() {
        return this.tagKey;
    }

    public IndustryManufactureMesTeamMgmtRequest setTagValues(java.util.List<String> tagValues) {
        this.tagValues = tagValues;
        return this;
    }
    public java.util.List<String> getTagValues() {
        return this.tagValues;
    }

    public static class IndustryManufactureMesTeamMgmtRequestExtendData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static IndustryManufactureMesTeamMgmtRequestExtendData build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesTeamMgmtRequestExtendData self = new IndustryManufactureMesTeamMgmtRequestExtendData();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesTeamMgmtRequestExtendData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public IndustryManufactureMesTeamMgmtRequestExtendData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesTeamMgmtRequestExtendData setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public IndustryManufactureMesTeamMgmtRequestExtendData setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class IndustryManufactureMesTeamMgmtRequestGroupPlugins extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static IndustryManufactureMesTeamMgmtRequestGroupPlugins build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesTeamMgmtRequestGroupPlugins self = new IndustryManufactureMesTeamMgmtRequestGroupPlugins();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesTeamMgmtRequestGroupPlugins setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public IndustryManufactureMesTeamMgmtRequestGroupPlugins setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class IndustryManufactureMesTeamMgmtRequestLeaders extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static IndustryManufactureMesTeamMgmtRequestLeaders build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesTeamMgmtRequestLeaders self = new IndustryManufactureMesTeamMgmtRequestLeaders();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesTeamMgmtRequestLeaders setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesTeamMgmtRequestLeaders setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class IndustryManufactureMesTeamMgmtRequestMembers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static IndustryManufactureMesTeamMgmtRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesTeamMgmtRequestMembers self = new IndustryManufactureMesTeamMgmtRequestMembers();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesTeamMgmtRequestMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesTeamMgmtRequestMembers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
