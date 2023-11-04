// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppShrinkRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("feature")
    public String featureShrink;

    @NameInMap("installUid")
    public String installUid;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("options")
    public String optionsShrink;

    @NameInMap("suiteId")
    public String suiteId;

    public static InstallCoolAppShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppShrinkRequest self = new InstallCoolAppShrinkRequest();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppShrinkRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public InstallCoolAppShrinkRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public InstallCoolAppShrinkRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public InstallCoolAppShrinkRequest setFeatureShrink(String featureShrink) {
        this.featureShrink = featureShrink;
        return this;
    }
    public String getFeatureShrink() {
        return this.featureShrink;
    }

    public InstallCoolAppShrinkRequest setInstallUid(String installUid) {
        this.installUid = installUid;
        return this;
    }
    public String getInstallUid() {
        return this.installUid;
    }

    public InstallCoolAppShrinkRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public InstallCoolAppShrinkRequest setOptionsShrink(String optionsShrink) {
        this.optionsShrink = optionsShrink;
        return this;
    }
    public String getOptionsShrink() {
        return this.optionsShrink;
    }

    public InstallCoolAppShrinkRequest setSuiteId(String suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public String getSuiteId() {
        return this.suiteId;
    }

}
