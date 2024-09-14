// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateScheduleConfSettingsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("scheduleConfSettingModel")
    public UpdateScheduleConfSettingsRequestScheduleConfSettingModel scheduleConfSettingModel;

    /**
     * <strong>example:</strong>
     * <p>f6fb627e-a7e8-403e-b1f8-26e85450f4a9</p>
     */
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

    public static class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true：跟随 false：不跟随</p>
         */
        @NameInMap("isFollowHost")
        public Boolean isFollowHost;

        /**
         * <strong>example:</strong>
         * <p>grid：宫格模式,默认9宫格(3x3) speech：演讲者模式 full_screen：全屏模式 auto_grid：自动宫格模式，默认最大4x4宫格 screen_cast：屏幕共享模式，仅放置屏幕共享流 p2p：双人通话模式 full_screen_and_speaker：共享内容+发言人模式</p>
         */
        @NameInMap("mode")
        public String mode;

        /**
         * <strong>example:</strong>
         * <p>0：不自动开启 1：自动开启</p>
         */
        @NameInMap("recordAutoStart")
        public Integer recordAutoStart;

        /**
         * <strong>example:</strong>
         * <p>0：我以主持人身份入会后自动开启 1：其他人以联席主持人身份入会后开启 2：任何人以任何身份入会后开启</p>
         */
        @NameInMap("recordAutoStartType")
        public Integer recordAutoStartType;

        public static UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting build(java.util.Map<String, ?> map) throws Exception {
            UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting self = new UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting();
            return TeaModel.build(map, self);
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting setIsFollowHost(Boolean isFollowHost) {
            this.isFollowHost = isFollowHost;
            return this;
        }
        public Boolean getIsFollowHost() {
            return this.isFollowHost;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting setRecordAutoStart(Integer recordAutoStart) {
            this.recordAutoStart = recordAutoStart;
            return this;
        }
        public Integer getRecordAutoStart() {
            return this.recordAutoStart;
        }

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting setRecordAutoStartType(Integer recordAutoStartType) {
            this.recordAutoStartType = recordAutoStartType;
            return this;
        }
        public Integer getRecordAutoStartType() {
            return this.recordAutoStartType;
        }

    }

    public static class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0：不自动打开 1：仅主持人/联席主持人自动打开 2：全员自动打开</p>
         */
        @NameInMap("autoOpenMode")
        public Integer autoOpenMode;

        /**
         * <strong>example:</strong>
         * <p>COOLAPP-0-1026633886192127xxxB000W</p>
         */
        @NameInMap("coolAppCode")
        public String coolAppCode;

        /**
         * <strong>example:</strong>
         * <p>bizData</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
         */
        @NameInMap("cloudRecordOwnerUnionId")
        public String cloudRecordOwnerUnionId;

        /**
         * <strong>example:</strong>
         * <p>0：未开启 1：开启</p>
         */
        @NameInMap("enableChat")
        public Integer enableChat;

        /**
         * <strong>example:</strong>
         * <p>true：允许匿名登录入会 false：不允许匿名登录入会</p>
         */
        @NameInMap("enableWebAnonymousJoin")
        public Boolean enableWebAnonymousJoin;

        /**
         * <strong>example:</strong>
         * <p>0：未开启 1：开启</p>
         */
        @NameInMap("joinBeforeHost")
        public Integer joinBeforeHost;

        /**
         * <strong>example:</strong>
         * <p>0：未开启 1：开启</p>
         */
        @NameInMap("lockMediaStatusMicMute")
        public Integer lockMediaStatusMicMute;

        /**
         * <strong>example:</strong>
         * <p>0：未开启 1：开启</p>
         */
        @NameInMap("lockNick")
        public Integer lockNick;

        /**
         * <strong>example:</strong>
         * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
         */
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

        /**
         * <strong>example:</strong>
         * <p>0：未开启 1：开启</p>
         */
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

        /**
         * <strong>example:</strong>
         * <p>dingc02f685fa06381c44ac5d6980864d335</p>
         */
        @NameInMap("confAllowedCorpId")
        public String confAllowedCorpId;

        /**
         * <strong>example:</strong>
         * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
         */
        @NameInMap("hostUnionId")
        public String hostUnionId;

        /**
         * <strong>example:</strong>
         * <p>0：取消锁定 1：锁定</p>
         */
        @NameInMap("lockRoom")
        public Integer lockRoom;

        @NameInMap("moziConfOpenRecordSetting")
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting moziConfOpenRecordSetting;

        @NameInMap("moziConfVirtualExtraSetting")
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting;

        /**
         * <strong>example:</strong>
         * <p>-1：未开启 1：开启 6：超过6人自动开启静音</p>
         */
        @NameInMap("muteOnJoin")
        public Integer muteOnJoin;

        /**
         * <strong>example:</strong>
         * <p>0：允许共享 1：禁止共享</p>
         */
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

        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel setMoziConfOpenRecordSetting(UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting moziConfOpenRecordSetting) {
            this.moziConfOpenRecordSetting = moziConfOpenRecordSetting;
            return this;
        }
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting getMoziConfOpenRecordSetting() {
            return this.moziConfOpenRecordSetting;
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
