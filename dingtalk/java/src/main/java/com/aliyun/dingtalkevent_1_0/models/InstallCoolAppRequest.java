// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("feature")
    public java.util.Map<String, ?> feature;

    @NameInMap("installUid")
    public String installUid;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("options")
    public java.util.Map<String, ?> options;

    @NameInMap("suiteId")
    public String suiteId;

    public static InstallCoolAppRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppRequest self = new InstallCoolAppRequest();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public InstallCoolAppRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public InstallCoolAppRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public InstallCoolAppRequest setFeature(java.util.Map<String, ?> feature) {
        this.feature = feature;
        return this;
    }
    public java.util.Map<String, ?> getFeature() {
        return this.feature;
    }

    public InstallCoolAppRequest setInstallUid(String installUid) {
        this.installUid = installUid;
        return this;
    }
    public String getInstallUid() {
        return this.installUid;
    }

    public InstallCoolAppRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public InstallCoolAppRequest setOptions(java.util.Map<String, ?> options) {
        this.options = options;
        return this;
    }
    public java.util.Map<String, ?> getOptions() {
        return this.options;
    }

    public InstallCoolAppRequest setSuiteId(String suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public String getSuiteId() {
        return this.suiteId;
    }

}
