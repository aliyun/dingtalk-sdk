// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConfSettingsResponseBody extends TeaModel {
    @NameInMap("scheduleConfSettingModel")
    public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel scheduleConfSettingModel;

    public static QueryScheduleConfSettingsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConfSettingsResponseBody self = new QueryScheduleConfSettingsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConfSettingsResponseBody setScheduleConfSettingModel(QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel scheduleConfSettingModel) {
        this.scheduleConfSettingModel = scheduleConfSettingModel;
        return this;
    }
    public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel getScheduleConfSettingModel() {
        return this.scheduleConfSettingModel;
    }

    public static class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends TeaModel {
        @NameInMap("autoOpenMode")
        public String autoOpenMode;

        @NameInMap("clientId")
        public String clientId;

        @NameInMap("coolAppCode")
        public String coolAppCode;

        @NameInMap("extensionAppBizData")
        public String extensionAppBizData;

        public static QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings build(java.util.Map<String, ?> map) throws Exception {
            QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings self = new QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings();
            return TeaModel.build(map, self);
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setAutoOpenMode(String autoOpenMode) {
            this.autoOpenMode = autoOpenMode;
            return this;
        }
        public String getAutoOpenMode() {
            return this.autoOpenMode;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setClientId(String clientId) {
            this.clientId = clientId;
            return this;
        }
        public String getClientId() {
            return this.clientId;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setExtensionAppBizData(String extensionAppBizData) {
            this.extensionAppBizData = extensionAppBizData;
            return this;
        }
        public String getExtensionAppBizData() {
            return this.extensionAppBizData;
        }

    }

    public static class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting extends TeaModel {
        @NameInMap("enableChat")
        public Integer enableChat;

        @NameInMap("enableWebAnonymousJoin")
        public Boolean enableWebAnonymousJoin;

        @NameInMap("joinBeforeHost")
        public Integer joinBeforeHost;

        @NameInMap("lockMediaStatusMicMute")
        public Integer lockMediaStatusMicMute;

        @NameInMap("lockNick")
        public Integer lockNick;

        @NameInMap("moziConfExtensionAppSettings")
        public java.util.List<QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> moziConfExtensionAppSettings;

        @NameInMap("waitingRoom")
        public Integer waitingRoom;

        public static QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting build(java.util.Map<String, ?> map) throws Exception {
            QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting self = new QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting();
            return TeaModel.build(map, self);
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setEnableChat(Integer enableChat) {
            this.enableChat = enableChat;
            return this;
        }
        public Integer getEnableChat() {
            return this.enableChat;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setEnableWebAnonymousJoin(Boolean enableWebAnonymousJoin) {
            this.enableWebAnonymousJoin = enableWebAnonymousJoin;
            return this;
        }
        public Boolean getEnableWebAnonymousJoin() {
            return this.enableWebAnonymousJoin;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setJoinBeforeHost(Integer joinBeforeHost) {
            this.joinBeforeHost = joinBeforeHost;
            return this;
        }
        public Integer getJoinBeforeHost() {
            return this.joinBeforeHost;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setLockMediaStatusMicMute(Integer lockMediaStatusMicMute) {
            this.lockMediaStatusMicMute = lockMediaStatusMicMute;
            return this;
        }
        public Integer getLockMediaStatusMicMute() {
            return this.lockMediaStatusMicMute;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setLockNick(Integer lockNick) {
            this.lockNick = lockNick;
            return this;
        }
        public Integer getLockNick() {
            return this.lockNick;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setMoziConfExtensionAppSettings(java.util.List<QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> moziConfExtensionAppSettings) {
            this.moziConfExtensionAppSettings = moziConfExtensionAppSettings;
            return this;
        }
        public java.util.List<QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> getMoziConfExtensionAppSettings() {
            return this.moziConfExtensionAppSettings;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting setWaitingRoom(Integer waitingRoom) {
            this.waitingRoom = waitingRoom;
            return this;
        }
        public Integer getWaitingRoom() {
            return this.waitingRoom;
        }

    }

    public static class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel extends TeaModel {
        @NameInMap("cohostUnionIds")
        public java.util.List<String> cohostUnionIds;

        @NameInMap("confAllowedCorpId")
        public String confAllowedCorpId;

        @NameInMap("hostUnionId")
        public String hostUnionId;

        @NameInMap("lockRoom")
        public Integer lockRoom;

        @NameInMap("moziConfVirtualExtraSetting")
        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting;

        @NameInMap("muteOnJoin")
        public Integer muteOnJoin;

        @NameInMap("screenShareForbidden")
        public Integer screenShareForbidden;

        public static QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel build(java.util.Map<String, ?> map) throws Exception {
            QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel self = new QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel();
            return TeaModel.build(map, self);
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setCohostUnionIds(java.util.List<String> cohostUnionIds) {
            this.cohostUnionIds = cohostUnionIds;
            return this;
        }
        public java.util.List<String> getCohostUnionIds() {
            return this.cohostUnionIds;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setConfAllowedCorpId(String confAllowedCorpId) {
            this.confAllowedCorpId = confAllowedCorpId;
            return this;
        }
        public String getConfAllowedCorpId() {
            return this.confAllowedCorpId;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setHostUnionId(String hostUnionId) {
            this.hostUnionId = hostUnionId;
            return this;
        }
        public String getHostUnionId() {
            return this.hostUnionId;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setLockRoom(Integer lockRoom) {
            this.lockRoom = lockRoom;
            return this;
        }
        public Integer getLockRoom() {
            return this.lockRoom;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setMoziConfVirtualExtraSetting(QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting) {
            this.moziConfVirtualExtraSetting = moziConfVirtualExtraSetting;
            return this;
        }
        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting getMoziConfVirtualExtraSetting() {
            return this.moziConfVirtualExtraSetting;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setMuteOnJoin(Integer muteOnJoin) {
            this.muteOnJoin = muteOnJoin;
            return this;
        }
        public Integer getMuteOnJoin() {
            return this.muteOnJoin;
        }

        public QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel setScreenShareForbidden(Integer screenShareForbidden) {
            this.screenShareForbidden = screenShareForbidden;
            return this;
        }
        public Integer getScreenShareForbidden() {
            return this.screenShareForbidden;
        }

    }

}
