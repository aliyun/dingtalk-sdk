// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListFormRemarksRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    @NameInMap("formUuid")
    public String formUuid;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("userId")
    public String userId;

    public static ListFormRemarksRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFormRemarksRequest self = new ListFormRemarksRequest();
        return TeaModel.build(map, self);
    }

    public ListFormRemarksRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ListFormRemarksRequest setFormInstanceIdList(java.util.List<String> formInstanceIdList) {
        this.formInstanceIdList = formInstanceIdList;
        return this;
    }
    public java.util.List<String> getFormInstanceIdList() {
        return this.formInstanceIdList;
    }

    public ListFormRemarksRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public ListFormRemarksRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ListFormRemarksRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
