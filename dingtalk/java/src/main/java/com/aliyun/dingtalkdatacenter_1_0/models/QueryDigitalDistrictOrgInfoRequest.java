// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDigitalDistrictOrgInfoRequest extends TeaModel {
    @NameInMap("kpiGroupId")
    public String kpiGroupId;

    @NameInMap("statDates")
    public java.util.List<String> statDates;

    @NameInMap("orgIds")
    public java.util.List<String> orgIds;

    public static QueryDigitalDistrictOrgInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDigitalDistrictOrgInfoRequest self = new QueryDigitalDistrictOrgInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryDigitalDistrictOrgInfoRequest setKpiGroupId(String kpiGroupId) {
        this.kpiGroupId = kpiGroupId;
        return this;
    }
    public String getKpiGroupId() {
        return this.kpiGroupId;
    }

    public QueryDigitalDistrictOrgInfoRequest setStatDates(java.util.List<String> statDates) {
        this.statDates = statDates;
        return this;
    }
    public java.util.List<String> getStatDates() {
        return this.statDates;
    }

    public QueryDigitalDistrictOrgInfoRequest setOrgIds(java.util.List<String> orgIds) {
        this.orgIds = orgIds;
        return this;
    }
    public java.util.List<String> getOrgIds() {
        return this.orgIds;
    }

}
