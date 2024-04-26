// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomShortLinkRequest extends TeaModel {
    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("extensionAppBizData")
    public String extensionAppBizData;

    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

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
