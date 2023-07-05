// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0.models;

import com.aliyun.tea.*;

public class SendLiveActivityRequest extends TeaModel {
    @NameInMap("activityEventData")
    public SendLiveActivityRequestActivityEventData activityEventData;

    @NameInMap("activityEventOption")
    public SendLiveActivityRequestActivityEventOption activityEventOption;

    @NameInMap("activityId")
    public String activityId;

    public static SendLiveActivityRequest build(java.util.Map<String, ?> map) throws Exception {
        SendLiveActivityRequest self = new SendLiveActivityRequest();
        return TeaModel.build(map, self);
    }

    public SendLiveActivityRequest setActivityEventData(SendLiveActivityRequestActivityEventData activityEventData) {
        this.activityEventData = activityEventData;
        return this;
    }
    public SendLiveActivityRequestActivityEventData getActivityEventData() {
        return this.activityEventData;
    }

    public SendLiveActivityRequest setActivityEventOption(SendLiveActivityRequestActivityEventOption activityEventOption) {
        this.activityEventOption = activityEventOption;
        return this;
    }
    public SendLiveActivityRequestActivityEventOption getActivityEventOption() {
        return this.activityEventOption;
    }

    public SendLiveActivityRequest setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

    public static class SendLiveActivityRequestActivityEventData extends TeaModel {
        @NameInMap("i18nContentState")
        public Object i18nContentState;

        @NameInMap("templateId")
        public String templateId;

        public static SendLiveActivityRequestActivityEventData build(java.util.Map<String, ?> map) throws Exception {
            SendLiveActivityRequestActivityEventData self = new SendLiveActivityRequestActivityEventData();
            return TeaModel.build(map, self);
        }

        public SendLiveActivityRequestActivityEventData setI18nContentState(Object i18nContentState) {
            this.i18nContentState = i18nContentState;
            return this;
        }
        public Object getI18nContentState() {
            return this.i18nContentState;
        }

        public SendLiveActivityRequestActivityEventData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

    }

    public static class SendLiveActivityRequestActivityEventOption extends TeaModel {
        @NameInMap("dismissalDate")
        public Long dismissalDate;

        @NameInMap("pushType")
        public String pushType;

        @NameInMap("sendDate")
        public Long sendDate;

        @NameInMap("staleDate")
        public Long staleDate;

        public static SendLiveActivityRequestActivityEventOption build(java.util.Map<String, ?> map) throws Exception {
            SendLiveActivityRequestActivityEventOption self = new SendLiveActivityRequestActivityEventOption();
            return TeaModel.build(map, self);
        }

        public SendLiveActivityRequestActivityEventOption setDismissalDate(Long dismissalDate) {
            this.dismissalDate = dismissalDate;
            return this;
        }
        public Long getDismissalDate() {
            return this.dismissalDate;
        }

        public SendLiveActivityRequestActivityEventOption setPushType(String pushType) {
            this.pushType = pushType;
            return this;
        }
        public String getPushType() {
            return this.pushType;
        }

        public SendLiveActivityRequestActivityEventOption setSendDate(Long sendDate) {
            this.sendDate = sendDate;
            return this;
        }
        public Long getSendDate() {
            return this.sendDate;
        }

        public SendLiveActivityRequestActivityEventOption setStaleDate(Long staleDate) {
            this.staleDate = staleDate;
            return this;
        }
        public Long getStaleDate() {
            return this.staleDate;
        }

    }

}
