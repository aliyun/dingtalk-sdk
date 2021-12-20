// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpacesInfoRequest extends TeaModel {
    @NameInMap("residentCorpId")
    public String residentCorpId;

    @NameInMap("referIds")
    public java.util.List<Long> referIds;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    public static GetSpacesInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpacesInfoRequest self = new GetSpacesInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetSpacesInfoRequest setResidentCorpId(String residentCorpId) {
        this.residentCorpId = residentCorpId;
        return this;
    }
    public String getResidentCorpId() {
        return this.residentCorpId;
    }

    public GetSpacesInfoRequest setReferIds(java.util.List<Long> referIds) {
        this.referIds = referIds;
        return this;
    }
    public java.util.List<Long> getReferIds() {
        return this.referIds;
    }

    public GetSpacesInfoRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public GetSpacesInfoRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public GetSpacesInfoRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetSpacesInfoRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

}
