// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class InstallAppRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("suiteId")
    public Long suiteId;

    public static InstallAppRequest build(java.util.Map<String, ?> map) throws Exception {
        InstallAppRequest self = new InstallAppRequest();
        return TeaModel.build(map, self);
    }

    public InstallAppRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public InstallAppRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public InstallAppRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public InstallAppRequest setSuiteId(Long suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public Long getSuiteId() {
        return this.suiteId;
    }

}
