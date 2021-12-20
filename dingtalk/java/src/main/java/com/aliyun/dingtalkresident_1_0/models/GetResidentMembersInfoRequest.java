// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentMembersInfoRequest extends TeaModel {
    @NameInMap("residentCropId")
    public String residentCropId;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static GetResidentMembersInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResidentMembersInfoRequest self = new GetResidentMembersInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetResidentMembersInfoRequest setResidentCropId(String residentCropId) {
        this.residentCropId = residentCropId;
        return this;
    }
    public String getResidentCropId() {
        return this.residentCropId;
    }

    public GetResidentMembersInfoRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

    public GetResidentMembersInfoRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public GetResidentMembersInfoRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetResidentMembersInfoRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public GetResidentMembersInfoRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
