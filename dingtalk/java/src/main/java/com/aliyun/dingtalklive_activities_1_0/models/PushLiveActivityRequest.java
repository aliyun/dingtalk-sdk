// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0.models;

import com.aliyun.tea.*;

public class PushLiveActivityRequest extends TeaModel {
    @NameInMap("activityEventData")
    public PushLiveActivityRequestActivityEventData activityEventData;

    @NameInMap("activityEventOption")
    public PushLiveActivityRequestActivityEventOption activityEventOption;

    /**
     * <strong>example:</strong>
     * <p>bizUniqueId</p>
     */
    @NameInMap("activityId")
    public String activityId;

    public static PushLiveActivityRequest build(java.util.Map<String, ?> map) throws Exception {
        PushLiveActivityRequest self = new PushLiveActivityRequest();
        return TeaModel.build(map, self);
    }

    public PushLiveActivityRequest setActivityEventData(PushLiveActivityRequestActivityEventData activityEventData) {
        this.activityEventData = activityEventData;
        return this;
    }
    public PushLiveActivityRequestActivityEventData getActivityEventData() {
        return this.activityEventData;
    }

    public PushLiveActivityRequest setActivityEventOption(PushLiveActivityRequestActivityEventOption activityEventOption) {
        this.activityEventOption = activityEventOption;
        return this;
    }
    public PushLiveActivityRequestActivityEventOption getActivityEventOption() {
        return this.activityEventOption;
    }

    public PushLiveActivityRequest setActivityId(String activityId) {
        this.activityId = activityId;
        return this;
    }
    public String getActivityId() {
        return this.activityId;
    }

    public static class PushLiveActivityRequestActivityEventData extends TeaModel {
        @NameInMap("i18nContentState")
        public Object i18nContentState;

        /**
         * <strong>example:</strong>
         * <p>ride_with_alibtrip</p>
         */
        @NameInMap("templateId")
        public String templateId;

        public static PushLiveActivityRequestActivityEventData build(java.util.Map<String, ?> map) throws Exception {
            PushLiveActivityRequestActivityEventData self = new PushLiveActivityRequestActivityEventData();
            return TeaModel.build(map, self);
        }

        public PushLiveActivityRequestActivityEventData setI18nContentState(Object i18nContentState) {
            this.i18nContentState = i18nContentState;
            return this;
        }
        public Object getI18nContentState() {
            return this.i18nContentState;
        }

        public PushLiveActivityRequestActivityEventData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

    }

    public static class PushLiveActivityRequestActivityEventOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1686903998</p>
         */
        @NameInMap("dismissalDate")
        public Long dismissalDate;

        /**
         * <strong>example:</strong>
         * <p>update</p>
         */
        @NameInMap("pushType")
        public String pushType;

        /**
         * <strong>example:</strong>
         * <p>1686903998</p>
         */
        @NameInMap("sendDate")
        public Long sendDate;

        /**
         * <strong>example:</strong>
         * <p>1686903998</p>
         */
        @NameInMap("staleDate")
        public Long staleDate;

        public static PushLiveActivityRequestActivityEventOption build(java.util.Map<String, ?> map) throws Exception {
            PushLiveActivityRequestActivityEventOption self = new PushLiveActivityRequestActivityEventOption();
            return TeaModel.build(map, self);
        }

        public PushLiveActivityRequestActivityEventOption setDismissalDate(Long dismissalDate) {
            this.dismissalDate = dismissalDate;
            return this;
        }
        public Long getDismissalDate() {
            return this.dismissalDate;
        }

        public PushLiveActivityRequestActivityEventOption setPushType(String pushType) {
            this.pushType = pushType;
            return this;
        }
        public String getPushType() {
            return this.pushType;
        }

        public PushLiveActivityRequestActivityEventOption setSendDate(Long sendDate) {
            this.sendDate = sendDate;
            return this;
        }
        public Long getSendDate() {
            return this.sendDate;
        }

        public PushLiveActivityRequestActivityEventOption setStaleDate(Long staleDate) {
            this.staleDate = staleDate;
            return this;
        }
        public Long getStaleDate() {
            return this.staleDate;
        }

    }

}
