// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DistributePartnerAppRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("subCorpId")
    public String subCorpId;

    @NameInMap("type")
    public Long type;

    public static DistributePartnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        DistributePartnerAppRequest self = new DistributePartnerAppRequest();
        return TeaModel.build(map, self);
    }

    public DistributePartnerAppRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public DistributePartnerAppRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public DistributePartnerAppRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public DistributePartnerAppRequest setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

}
