// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetEmployeeRosterByFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("appAgentId")
    public Long appAgentId;

    @NameInMap("fieldFilterList")
    public java.util.List<String> fieldFilterList;

    @NameInMap("text2SelectConvert")
    public Boolean text2SelectConvert;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static GetEmployeeRosterByFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEmployeeRosterByFieldRequest self = new GetEmployeeRosterByFieldRequest();
        return TeaModel.build(map, self);
    }

    public GetEmployeeRosterByFieldRequest setAppAgentId(Long appAgentId) {
        this.appAgentId = appAgentId;
        return this;
    }
    public Long getAppAgentId() {
        return this.appAgentId;
    }

    public GetEmployeeRosterByFieldRequest setFieldFilterList(java.util.List<String> fieldFilterList) {
        this.fieldFilterList = fieldFilterList;
        return this;
    }
    public java.util.List<String> getFieldFilterList() {
        return this.fieldFilterList;
    }

    public GetEmployeeRosterByFieldRequest setText2SelectConvert(Boolean text2SelectConvert) {
        this.text2SelectConvert = text2SelectConvert;
        return this;
    }
    public Boolean getText2SelectConvert() {
        return this.text2SelectConvert;
    }

    public GetEmployeeRosterByFieldRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
