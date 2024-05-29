// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateScheduleConfSettingsRequest extends TeaModel {
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("scheduleConfSettingModel")
    public UpdateScheduleConfSettingsRequestScheduleConfSettingModel scheduleConfSettingModel;

    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    public static UpdateScheduleConfSettingsRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateScheduleConfSettingsRequest self = new UpdateScheduleConfSettingsRequest();
        return TeaModel.build(map, self);
    }

    public UpdateScheduleConfSettingsRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public UpdateScheduleConfSettingsRequest setScheduleConfSettingModel(UpdateScheduleConfSettingsRequestScheduleConfSettingModel scheduleConfSettingModel) {
        this.scheduleConfSettingModel = scheduleConfSettingModel;
        return this;
    }
    public UpdateScheduleConfSettingsRequestScheduleConfSettingModel getScheduleConfSettingModel() {
        return this.scheduleConfSettingModel;
    }

    public UpdateScheduleConfSettingsRequest setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

    public static class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends TeaModel {
        @NameInMap("autoOpenMode")
        public Integer autoOpenMode;

        @NameInMap("coolAppCode")
        public String coolAppCode;

        @NameInMap("extensionAppBizData")
        public String extensionAppBizData;

        public static UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings build(java.util.Map<String, ?> map) throws Exception {
            UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings self = new UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings();
            return TeaModel.build(map, self);
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setAutoOpenMode(Integer autoOpenMode) {
            this.autoOpenMode = autoOpenMode;
            return this;
        }
        public Integer getAutoOpenMode() {
            return this.autoOpenMode;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setExtensionAppBizData(String extensionAppBizData) {
            this.extensionAppBizData = extensionAppBizData;
            return this;
        }
        public String getExtensionAppBizData() {
            return this.extensionAppBizData;
        }

    }

    public static class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting extends TeaModel {
        @NameInMap("cloudRecordOwnerUnionId")
        public String cloudRecordOwnerUnionId;

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

        @NameInMap("minutesOwnerUnionId")
        public String minutesOwnerUnionId;

        @NameInMap("moziConfExtensionAppSettings")
        public java.util.List<UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> moziConfExtensionAppSettings;

        @NameInMap("pushAllMeetingRecords")
        public Boolean pushAllMeetingRecords;

        @NameInMap("pushCloudRecordCard")
        public Boolean pushCloudRecordCard;

        @NameInMap("pushMinutesCard")
        public Boolean pushMinutesCard;

        @NameInMap("waitingRoom")
        public Integer waitingRoom;

        public static UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting build(java.util.Map<String, ?> map) throws Exception {
            UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting self = new UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting();
            return TeaModel.build(map, self);
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setCloudRecordOwnerUnionId(String cloudRecordOwnerUnionId) {
            this.cloudRecordOwnerUnionId = cloudRecordOwnerUnionId;
            return this;
        }
        public String getCloudRecordOwnerUnionId() {
            return this.cloudRecordOwnerUnionId;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setEnableChat(Integer enableChat) {
            this.enableChat = enableChat;
            return this;
        }
        public Integer getEnableChat() {
            return this.enableChat;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setEnableWebAnonymousJoin(Boolean enableWebAnonymousJoin) {
            this.enableWebAnonymousJoin = enableWebAnonymousJoin;
            return this;
        }
        public Boolean getEnableWebAnonymousJoin() {
            return this.enableWebAnonymousJoin;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setJoinBeforeHost(Integer joinBeforeHost) {
            this.joinBeforeHost = joinBeforeHost;
            return this;
        }
        public Integer getJoinBeforeHost() {
            return this.joinBeforeHost;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setLockMediaStatusMicMute(Integer lockMediaStatusMicMute) {
            this.lockMediaStatusMicMute = lockMediaStatusMicMute;
            return this;
        }
        public Integer getLockMediaStatusMicMute() {
            return this.lockMediaStatusMicMute;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setLockNick(Integer lockNick) {
            this.lockNick = lockNick;
            return this;
        }
        public Integer getLockNick() {
            return this.lockNick;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setMinutesOwnerUnionId(String minutesOwnerUnionId) {
            this.minutesOwnerUnionId = minutesOwnerUnionId;
            return this;
        }
        public String getMinutesOwnerUnionId() {
            return this.minutesOwnerUnionId;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setMoziConfExtensionAppSettings(java.util.List<UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> moziConfExtensionAppSettings) {
            this.moziConfExtensionAppSettings = moziConfExtensionAppSettings;
            return this;
        }
        public java.util.List<UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> getMoziConfExtensionAppSettings() {
            return this.moziConfExtensionAppSettings;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setPushAllMeetingRecords(Boolean pushAllMeetingRecords) {
            this.pushAllMeetingRecords = pushAllMeetingRecords;
            return this;
        }
        public Boolean getPushAllMeetingRecords() {
            return this.pushAllMeetingRecords;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setPushCloudRecordCard(Boolean pushCloudRecordCard) {
            this.pushCloudRecordCard = pushCloudRecordCard;
            return this;
        }
        public Boolean getPushCloudRecordCard() {
            return this.pushCloudRecordCard;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setPushMinutesCard(Boolean pushMinutesCard) {
            this.pushMinutesCard = pushMinutesCard;
            return this;
        }
        public Boolean getPushMinutesCard() {
            return this.pushMinutesCard;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setWaitingRoom(Integer waitingRoom) {
            this.waitingRoom = waitingRoom;
            return this;
        }
        public Integer getWaitingRoom() {
            return this.waitingRoom;
        }

    }

    public static class UpdateScheduleConfSettingsRequestScheduleConfSettingModel extends TeaModel {
        @NameInMap("cohostUnionIds")
        public java.util.List<String> cohostUnionIds;

        @NameInMap("confAllowedCorpId")
        public String confAllowedCorpId;

        @NameInMap("hostUnionId")
        public String hostUnionId;

        @NameInMap("lockRoom")
        public Integer lockRoom;

        @NameInMap("moziConfVirtualExtraSetting")
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting;

        @NameInMap("muteOnJoin")
        public Integer muteOnJoin;

        @NameInMap("screenShareForbidden")
        public Integer screenShareForbidden;

        public static UpdateScheduleConfSettingsRequestScheduleConfSettingModel build(java.util.Map<String, ?> map) throws Exception {
            UpdateScheduleConfSettingsRequestScheduleConfSettingModel self = new UpdateScheduleConfSettingsRequestScheduleConfSettingModel();
            return TeaModel.build(map, self);
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setCohostUnionIds(java.util.List<String> cohostUnionIds) {
            this.cohostUnionIds = cohostUnionIds;
            return this;
        }
        public java.util.List<String> getCohostUnionIds() {
            return this.cohostUnionIds;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setConfAllowedCorpId(String confAllowedCorpId) {
            this.confAllowedCorpId = confAllowedCorpId;
            return this;
        }
        public String getConfAllowedCorpId() {
            return this.confAllowedCorpId;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setHostUnionId(String hostUnionId) {
            this.hostUnionId = hostUnionId;
            return this;
        }
        public String getHostUnionId() {
            return this.hostUnionId;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setLockRoom(Integer lockRoom) {
            this.lockRoom = lockRoom;
            return this;
        }
        public Integer getLockRoom() {
            return this.lockRoom;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setMoziConfVirtualExtraSetting(UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting) {
            this.moziConfVirtualExtraSetting = moziConfVirtualExtraSetting;
            return this;
        }
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting getMoziConfVirtualExtraSetting() {
            return this.moziConfVirtualExtraSetting;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setMuteOnJoin(Integer muteOnJoin) {
            this.muteOnJoin = muteOnJoin;
            return this;
        }
        public Integer getMuteOnJoin() {
            return this.muteOnJoin;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setScreenShareForbidden(Integer screenShareForbidden) {
            this.screenShareForbidden = screenShareForbidden;
            return this;
        }
        public Integer getScreenShareForbidden() {
            return this.screenShareForbidden;
        }

    }

}
