// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class ExportMinutesTaskResultRequest extends TeaModel {
    @NameInMap("expireTime")
    public Long expireTime;

    @NameInMap("summaryExportSetting")
    public ExportMinutesTaskResultRequestSummaryExportSetting summaryExportSetting;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>text</p>
     */
    @NameInMap("taskType")
    public String taskType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>763xxxxxx325f32</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D5xxxxxxxxxxxxxxEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ExportMinutesTaskResultRequest build(java.util.Map<String, ?> map) throws Exception {
        ExportMinutesTaskResultRequest self = new ExportMinutesTaskResultRequest();
        return TeaModel.build(map, self);
    }

    public ExportMinutesTaskResultRequest setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public ExportMinutesTaskResultRequest setSummaryExportSetting(ExportMinutesTaskResultRequestSummaryExportSetting summaryExportSetting) {
        this.summaryExportSetting = summaryExportSetting;
        return this;
    }
    public ExportMinutesTaskResultRequestSummaryExportSetting getSummaryExportSetting() {
        return this.summaryExportSetting;
    }

    public ExportMinutesTaskResultRequest setTaskType(String taskType) {
        this.taskType = taskType;
        return this;
    }
    public String getTaskType() {
        return this.taskType;
    }

    public ExportMinutesTaskResultRequest setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public ExportMinutesTaskResultRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class ExportMinutesTaskResultRequestSummaryExportSetting extends TeaModel {
        @NameInMap("enableBilingual")
        public Boolean enableBilingual;

        /**
         * <strong>example:</strong>
         * <p>zh</p>
         */
        @NameInMap("targetLang")
        public String targetLang;

        public static ExportMinutesTaskResultRequestSummaryExportSetting build(java.util.Map<String, ?> map) throws Exception {
            ExportMinutesTaskResultRequestSummaryExportSetting self = new ExportMinutesTaskResultRequestSummaryExportSetting();
            return TeaModel.build(map, self);
        }

        public ExportMinutesTaskResultRequestSummaryExportSetting setEnableBilingual(Boolean enableBilingual) {
            this.enableBilingual = enableBilingual;
            return this;
        }
        public Boolean getEnableBilingual() {
            return this.enableBilingual;
        }

        public ExportMinutesTaskResultRequestSummaryExportSetting setTargetLang(String targetLang) {
            this.targetLang = targetLang;
            return this;
        }
        public String getTargetLang() {
            return this.targetLang;
        }

    }

}
