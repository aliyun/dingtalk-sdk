// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetFieldsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding3xxx__-PROC-42FF6625-9692-4003-B13C-307CAACEC354</p>
     */
    @NameInMap("dsId")
    public String dsId;

    /**
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryOfficialDatasetFieldsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetFieldsRequest self = new QueryOfficialDatasetFieldsRequest();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetFieldsRequest setDsId(String dsId) {
        this.dsId = dsId;
        return this;
    }
    public String getDsId() {
        return this.dsId;
    }

    public QueryOfficialDatasetFieldsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
