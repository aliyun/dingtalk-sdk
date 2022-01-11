// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchGetGroupSetConfigRequest extends TeaModel {
    // 配置项key列表
    @NameInMap("configKeys")
    public java.util.List<String> configKeys;

    // 开放群组id
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 开放团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    public static BatchGetGroupSetConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetGroupSetConfigRequest self = new BatchGetGroupSetConfigRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetGroupSetConfigRequest setConfigKeys(java.util.List<String> configKeys) {
        this.configKeys = configKeys;
        return this;
    }
    public java.util.List<String> getConfigKeys() {
        return this.configKeys;
    }

    public BatchGetGroupSetConfigRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public BatchGetGroupSetConfigRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
