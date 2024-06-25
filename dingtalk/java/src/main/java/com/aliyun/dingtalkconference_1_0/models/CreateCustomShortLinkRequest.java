// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomShortLinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>COOLAPP-0-1026633886192127xxxB000W</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <strong>example:</strong>
     * <p>bizData</p>
     */
    @NameInMap("extensionAppBizData")
    public String extensionAppBizData;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>f6fb627e-a7e8-403e-b1f8-26e85450f4a9</p>
     */
    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    /**
     * <strong>example:</strong>
     * <p>true：使用 false：不使用</p>
     */
    @NameInMap("useExtensionApp")
    public Boolean useExtensionApp;

    public static CreateCustomShortLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomShortLinkRequest self = new CreateCustomShortLinkRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomShortLinkRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public CreateCustomShortLinkRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CreateCustomShortLinkRequest setExtensionAppBizData(String extensionAppBizData) {
        this.extensionAppBizData = extensionAppBizData;
        return this;
    }
    public String getExtensionAppBizData() {
        return this.extensionAppBizData;
    }

    public CreateCustomShortLinkRequest setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

    public CreateCustomShortLinkRequest setUseExtensionApp(Boolean useExtensionApp) {
        this.useExtensionApp = useExtensionApp;
        return this;
    }
    public Boolean getUseExtensionApp() {
        return this.useExtensionApp;
    }

}
