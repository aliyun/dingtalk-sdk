// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDefinitionRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("groupId")
    public String groupId;

    @NameInMap("language")
    public String language;

    @NameInMap("nameSpace")
    public String nameSpace;

    @NameInMap("orderNumber")
    public String orderNumber;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("systemType")
    public String systemType;

    @NameInMap("userId")
    public String userId;

    public static GetProcessDefinitionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDefinitionRequest self = new GetProcessDefinitionRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessDefinitionRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetProcessDefinitionRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetProcessDefinitionRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public GetProcessDefinitionRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetProcessDefinitionRequest setNameSpace(String nameSpace) {
        this.nameSpace = nameSpace;
        return this;
    }
    public String getNameSpace() {
        return this.nameSpace;
    }

    public GetProcessDefinitionRequest setOrderNumber(String orderNumber) {
        this.orderNumber = orderNumber;
        return this;
    }
    public String getOrderNumber() {
        return this.orderNumber;
    }

    public GetProcessDefinitionRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetProcessDefinitionRequest setSystemType(String systemType) {
        this.systemType = systemType;
        return this;
    }
    public String getSystemType() {
        return this.systemType;
    }

    public GetProcessDefinitionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
