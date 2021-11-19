// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetRequest extends TeaModel {
    // openTeamId
    @NameInMap("openTeamId")
    public String openTeamId;

    // dingIsvOrgId
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // dingOrgId
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // dingSuiteKey
    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // dingTokenGrantType
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // groupSetName
    @NameInMap("groupSetName")
    public String groupSetName;

    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    public static CreateGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetRequest self = new CreateGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CreateGroupSetRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CreateGroupSetRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreateGroupSetRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateGroupSetRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateGroupSetRequest setGroupSetName(String groupSetName) {
        this.groupSetName = groupSetName;
        return this;
    }
    public String getGroupSetName() {
        return this.groupSetName;
    }

    public CreateGroupSetRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

}
