// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesSubCooperationTeamRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("appKey")
    public String appKey;

    @NameInMap("baseDataName")
    public String baseDataName;

    @NameInMap("events")
    public java.util.List<String> events;

    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestExtendData> extendData;

    @NameInMap("groupPlugins")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestGroupPlugins> groupPlugins;

    @NameInMap("groupType")
    public String groupType;

    @NameInMap("leaders")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestLeaders> leaders;

    @NameInMap("members")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestMembers> members;

    @NameInMap("name")
    public String name;

    @NameInMap("outCorpId")
    public String outCorpId;

    @NameInMap("processIds")
    public java.util.List<String> processIds;

    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesSubCooperationTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesSubCooperationTeamRequest self = new IndustryManufactureMesSubCooperationTeamRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesSubCooperationTeamRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setEvents(java.util.List<String> events) {
        this.events = events;
        return this;
    }
    public java.util.List<String> getEvents() {
        return this.events;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setExtendData(java.util.List<IndustryManufactureMesSubCooperationTeamRequestExtendData> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestExtendData> getExtendData() {
        return this.extendData;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setGroupPlugins(java.util.List<IndustryManufactureMesSubCooperationTeamRequestGroupPlugins> groupPlugins) {
        this.groupPlugins = groupPlugins;
        return this;
    }
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestGroupPlugins> getGroupPlugins() {
        return this.groupPlugins;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setGroupType(String groupType) {
        this.groupType = groupType;
        return this;
    }
    public String getGroupType() {
        return this.groupType;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setLeaders(java.util.List<IndustryManufactureMesSubCooperationTeamRequestLeaders> leaders) {
        this.leaders = leaders;
        return this;
    }
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestLeaders> getLeaders() {
        return this.leaders;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setMembers(java.util.List<IndustryManufactureMesSubCooperationTeamRequestMembers> members) {
        this.members = members;
        return this;
    }
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestMembers> getMembers() {
        return this.members;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setOutCorpId(String outCorpId) {
        this.outCorpId = outCorpId;
        return this;
    }
    public String getOutCorpId() {
        return this.outCorpId;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setProcessIds(java.util.List<String> processIds) {
        this.processIds = processIds;
        return this;
    }
    public java.util.List<String> getProcessIds() {
        return this.processIds;
    }

    public IndustryManufactureMesSubCooperationTeamRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class IndustryManufactureMesSubCooperationTeamRequestExtendData extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        @NameInMap("valueType")
        public String valueType;

        public static IndustryManufactureMesSubCooperationTeamRequestExtendData build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesSubCooperationTeamRequestExtendData self = new IndustryManufactureMesSubCooperationTeamRequestExtendData();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesSubCooperationTeamRequestExtendData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public IndustryManufactureMesSubCooperationTeamRequestExtendData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesSubCooperationTeamRequestExtendData setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public IndustryManufactureMesSubCooperationTeamRequestExtendData setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class IndustryManufactureMesSubCooperationTeamRequestGroupPlugins extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static IndustryManufactureMesSubCooperationTeamRequestGroupPlugins build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesSubCooperationTeamRequestGroupPlugins self = new IndustryManufactureMesSubCooperationTeamRequestGroupPlugins();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesSubCooperationTeamRequestGroupPlugins setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public IndustryManufactureMesSubCooperationTeamRequestGroupPlugins setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class IndustryManufactureMesSubCooperationTeamRequestLeaders extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static IndustryManufactureMesSubCooperationTeamRequestLeaders build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesSubCooperationTeamRequestLeaders self = new IndustryManufactureMesSubCooperationTeamRequestLeaders();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesSubCooperationTeamRequestLeaders setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesSubCooperationTeamRequestLeaders setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class IndustryManufactureMesSubCooperationTeamRequestMembers extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static IndustryManufactureMesSubCooperationTeamRequestMembers build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesSubCooperationTeamRequestMembers self = new IndustryManufactureMesSubCooperationTeamRequestMembers();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesSubCooperationTeamRequestMembers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesSubCooperationTeamRequestMembers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
