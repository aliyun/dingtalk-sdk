// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetRunningTaskListRequest extends TeaModel {
    // appType
    @NameInMap("appType")
    public String appType;

    // 流程实例id列表, 逗号分隔
    @NameInMap("processInstanceIdList")
    public String processInstanceIdList;

    // systemToken
    @NameInMap("systemToken")
    public String systemToken;

    // 用户所属的企业id
    @NameInMap("userCorpId")
    public String userCorpId;

    // userId
    @NameInMap("userId")
    public String userId;

    public static GetRunningTaskListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRunningTaskListRequest self = new GetRunningTaskListRequest();
        return TeaModel.build(map, self);
    }

    public GetRunningTaskListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetRunningTaskListRequest setProcessInstanceIdList(String processInstanceIdList) {
        this.processInstanceIdList = processInstanceIdList;
        return this;
    }
    public String getProcessInstanceIdList() {
        return this.processInstanceIdList;
    }

    public GetRunningTaskListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetRunningTaskListRequest setUserCorpId(String userCorpId) {
        this.userCorpId = userCorpId;
        return this;
    }
    public String getUserCorpId() {
        return this.userCorpId;
    }

    public GetRunningTaskListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
