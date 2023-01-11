// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesSubCooperationTeamRequest extends TeaModel {
    /**
     * <p>本次操作的行为，取值： ● add：增加   -- 创建群 ● update：更新 -- 群成员变更</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>ISV的唯一标识,由BPaaS分配</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>基础数据名称。比如班组</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <p>事件配置列表(启用卡片列表),所有枚举值： 任务分配提醒: TASK_ASSIGN_REMINDER 任务逾期提醒: TASK_OVERDUE_REMINDER 置顶加急任务: STICK_URGET_TASK 报工审批提醒: OUTPUT_APPROVE_REMINDER 报工审批反馈: OUTPUT_APPROVE_RESULT 班组概览 :TEAM_OVERVIEW 我的任务:MYTASK_OVERVIEW     例如： ["STICK_URGET_TASK","OUTPUT_APPROVE_REMINDER"]</p>
     */
    @NameInMap("events")
    public java.util.List<String> events;

    /**
     * <p>扩展字段</p>
     */
    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestExtendData> extendData;

    /**
     * <p>群插件列表</p>
     */
    @NameInMap("groupPlugins")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestGroupPlugins> groupPlugins;

    /**
     * <p>群类型，枚举</p>
     */
    @NameInMap("groupType")
    public String groupType;

    /**
     * <p>班组长(支持多个)</p>
     */
    @NameInMap("leaders")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestLeaders> leaders;

    /**
     * <p>班组成员(群成员)</p>
     */
    @NameInMap("members")
    public java.util.List<IndustryManufactureMesSubCooperationTeamRequestMembers> members;

    /**
     * <p>班组群名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>委外合作群所属组织</p>
     */
    @NameInMap("outCorpId")
    public String outCorpId;

    /**
     * <p>关联的工序</p>
     */
    @NameInMap("processIds")
    public java.util.List<String> processIds;

    /**
     * <p>班组模型实例的唯一Id， 由业务方传递</p>
     */
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
        /**
         * <p>字段唯一标识</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>字段中文描述</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>字段的取值</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>字段的类型(string,number,boolean)</p>
         */
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
        /**
         * <p>工人姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>工人staffNo</p>
         */
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
        /**
         * <p>工人姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>工人staffNo</p>
         */
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
