// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateScheduleConferenceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qzR1iSMDvzR9iP7Pxxxxxxxxxxxx</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1687928400000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("scheduleConfSettingModel")
    public CreateScheduleConferenceRequestScheduleConfSettingModel scheduleConfSettingModel;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1687924800000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>预约会议标题</p>
     */
    @NameInMap("title")
    public String title;

    public static CreateScheduleConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateScheduleConferenceRequest self = new CreateScheduleConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CreateScheduleConferenceRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CreateScheduleConferenceRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateScheduleConferenceRequest setScheduleConfSettingModel(CreateScheduleConferenceRequestScheduleConfSettingModel scheduleConfSettingModel) {
        this.scheduleConfSettingModel = scheduleConfSettingModel;
        return this;
    }
    public CreateScheduleConferenceRequestScheduleConfSettingModel getScheduleConfSettingModel() {
        return this.scheduleConfSettingModel;
    }

    public CreateScheduleConferenceRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateScheduleConferenceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting extends TeaModel {
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

        public static CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting build(java.util.Map<String, ?> map) throws Exception {
            CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting self = new CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting();
            return TeaModel.build(map, self);
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting setIsFollowHost(Boolean isFollowHost) {
            this.isFollowHost = isFollowHost;
            return this;
        }
        public Boolean getIsFollowHost() {
            return this.isFollowHost;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting setRecordAutoStart(Integer recordAutoStart) {
            this.recordAutoStart = recordAutoStart;
            return this;
        }
        public Integer getRecordAutoStart() {
            return this.recordAutoStart;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting setRecordAutoStartType(Integer recordAutoStartType) {
            this.recordAutoStartType = recordAutoStartType;
            return this;
        }
        public Integer getRecordAutoStartType() {
            return this.recordAutoStartType;
        }

    }

    public static class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends TeaModel {
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

        public static CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings build(java.util.Map<String, ?> map) throws Exception {
            CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings self = new CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings();
            return TeaModel.build(map, self);
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setAutoOpenMode(Integer autoOpenMode) {
            this.autoOpenMode = autoOpenMode;
            return this;
        }
        public Integer getAutoOpenMode() {
            return this.autoOpenMode;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setCoolAppCode(String coolAppCode) {
            this.coolAppCode = coolAppCode;
            return this;
        }
        public String getCoolAppCode() {
            return this.coolAppCode;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings setExtensionAppBizData(String extensionAppBizData) {
            this.extensionAppBizData = extensionAppBizData;
            return this;
        }
        public String getExtensionAppBizData() {
            return this.extensionAppBizData;
        }

    }

    public static class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting extends TeaModel {
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
        public java.util.List<CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> moziConfExtensionAppSettings;

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

        public static CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting build(java.util.Map<String, ?> map) throws Exception {
            CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting self = new CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting();
            return TeaModel.build(map, self);
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setCloudRecordOwnerUnionId(String cloudRecordOwnerUnionId) {
            this.cloudRecordOwnerUnionId = cloudRecordOwnerUnionId;
            return this;
        }
        public String getCloudRecordOwnerUnionId() {
            return this.cloudRecordOwnerUnionId;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setEnableChat(Integer enableChat) {
            this.enableChat = enableChat;
            return this;
        }
        public Integer getEnableChat() {
            return this.enableChat;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setEnableWebAnonymousJoin(Boolean enableWebAnonymousJoin) {
            this.enableWebAnonymousJoin = enableWebAnonymousJoin;
            return this;
        }
        public Boolean getEnableWebAnonymousJoin() {
            return this.enableWebAnonymousJoin;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setJoinBeforeHost(Integer joinBeforeHost) {
            this.joinBeforeHost = joinBeforeHost;
            return this;
        }
        public Integer getJoinBeforeHost() {
            return this.joinBeforeHost;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setLockMediaStatusMicMute(Integer lockMediaStatusMicMute) {
            this.lockMediaStatusMicMute = lockMediaStatusMicMute;
            return this;
        }
        public Integer getLockMediaStatusMicMute() {
            return this.lockMediaStatusMicMute;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setLockNick(Integer lockNick) {
            this.lockNick = lockNick;
            return this;
        }
        public Integer getLockNick() {
            return this.lockNick;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setMinutesOwnerUnionId(String minutesOwnerUnionId) {
            this.minutesOwnerUnionId = minutesOwnerUnionId;
            return this;
        }
        public String getMinutesOwnerUnionId() {
            return this.minutesOwnerUnionId;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setMoziConfExtensionAppSettings(java.util.List<CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> moziConfExtensionAppSettings) {
            this.moziConfExtensionAppSettings = moziConfExtensionAppSettings;
            return this;
        }
        public java.util.List<CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> getMoziConfExtensionAppSettings() {
            return this.moziConfExtensionAppSettings;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setPushAllMeetingRecords(Boolean pushAllMeetingRecords) {
            this.pushAllMeetingRecords = pushAllMeetingRecords;
            return this;
        }
        public Boolean getPushAllMeetingRecords() {
            return this.pushAllMeetingRecords;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setPushCloudRecordCard(Boolean pushCloudRecordCard) {
            this.pushCloudRecordCard = pushCloudRecordCard;
            return this;
        }
        public Boolean getPushCloudRecordCard() {
            return this.pushCloudRecordCard;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setPushMinutesCard(Boolean pushMinutesCard) {
            this.pushMinutesCard = pushMinutesCard;
            return this;
        }
        public Boolean getPushMinutesCard() {
            return this.pushMinutesCard;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting setWaitingRoom(Integer waitingRoom) {
            this.waitingRoom = waitingRoom;
            return this;
        }
        public Integer getWaitingRoom() {
            return this.waitingRoom;
        }

    }

    public static class CreateScheduleConferenceRequestScheduleConfSettingModel extends TeaModel {
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
        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting moziConfOpenRecordSetting;

        @NameInMap("moziConfVirtualExtraSetting")
        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting;

        /**
         * <strong>example:</strong>
         * <p>-1：开启 0：未开启 6：超过6人自动开启静音</p>
         */
        @NameInMap("muteOnJoin")
        public Integer muteOnJoin;

        /**
         * <strong>example:</strong>
         * <p>0：允许共享 1：禁止共享</p>
         */
        @NameInMap("screenShareForbidden")
        public Integer screenShareForbidden;

        public static CreateScheduleConferenceRequestScheduleConfSettingModel build(java.util.Map<String, ?> map) throws Exception {
            CreateScheduleConferenceRequestScheduleConfSettingModel self = new CreateScheduleConferenceRequestScheduleConfSettingModel();
            return TeaModel.build(map, self);
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setCohostUnionIds(java.util.List<String> cohostUnionIds) {
            this.cohostUnionIds = cohostUnionIds;
            return this;
        }
        public java.util.List<String> getCohostUnionIds() {
            return this.cohostUnionIds;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setConfAllowedCorpId(String confAllowedCorpId) {
            this.confAllowedCorpId = confAllowedCorpId;
            return this;
        }
        public String getConfAllowedCorpId() {
            return this.confAllowedCorpId;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setHostUnionId(String hostUnionId) {
            this.hostUnionId = hostUnionId;
            return this;
        }
        public String getHostUnionId() {
            return this.hostUnionId;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setLockRoom(Integer lockRoom) {
            this.lockRoom = lockRoom;
            return this;
        }
        public Integer getLockRoom() {
            return this.lockRoom;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setMoziConfOpenRecordSetting(CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting moziConfOpenRecordSetting) {
            this.moziConfOpenRecordSetting = moziConfOpenRecordSetting;
            return this;
        }
        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting getMoziConfOpenRecordSetting() {
            return this.moziConfOpenRecordSetting;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setMoziConfVirtualExtraSetting(CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting moziConfVirtualExtraSetting) {
            this.moziConfVirtualExtraSetting = moziConfVirtualExtraSetting;
            return this;
        }
        public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting getMoziConfVirtualExtraSetting() {
            return this.moziConfVirtualExtraSetting;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setMuteOnJoin(Integer muteOnJoin) {
            this.muteOnJoin = muteOnJoin;
            return this;
        }
        public Integer getMuteOnJoin() {
            return this.muteOnJoin;
        }

        public CreateScheduleConferenceRequestScheduleConfSettingModel setScreenShareForbidden(Integer screenShareForbidden) {
            this.screenShareForbidden = screenShareForbidden;
            return this;
        }
        public Integer getScreenShareForbidden() {
            return this.screenShareForbidden;
        }

    }

}
