// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchGetFormDataByIdListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</p>
     */
    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("needFormInstanceValue")
    public Boolean needFormInstanceValue;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding173982232112232</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchGetFormDataByIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetFormDataByIdListRequest self = new BatchGetFormDataByIdListRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetFormDataByIdListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public BatchGetFormDataByIdListRequest setFormInstanceIdList(java.util.List<String> formInstanceIdList) {
        this.formInstanceIdList = formInstanceIdList;
        return this;
    }
    public java.util.List<String> getFormInstanceIdList() {
        return this.formInstanceIdList;
    }

    public BatchGetFormDataByIdListRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public BatchGetFormDataByIdListRequest setNeedFormInstanceValue(Boolean needFormInstanceValue) {
        this.needFormInstanceValue = needFormInstanceValue;
        return this;
    }
    public Boolean getNeedFormInstanceValue() {
        return this.needFormInstanceValue;
    }

    public BatchGetFormDataByIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public BatchGetFormDataByIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
