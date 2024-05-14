// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDigitalDistrictOrgInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpIds")
    public java.util.List<String> corpIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDates")
    public java.util.List<String> statDates;

    public static QueryDigitalDistrictOrgInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDigitalDistrictOrgInfoRequest self = new QueryDigitalDistrictOrgInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryDigitalDistrictOrgInfoRequest setCorpIds(java.util.List<String> corpIds) {
        this.corpIds = corpIds;
        return this;
    }
    public java.util.List<String> getCorpIds() {
        return this.corpIds;
    }

    public QueryDigitalDistrictOrgInfoRequest setStatDates(java.util.List<String> statDates) {
        this.statDates = statDates;
        return this;
    }
    public java.util.List<String> getStatDates() {
        return this.statDates;
    }

}
