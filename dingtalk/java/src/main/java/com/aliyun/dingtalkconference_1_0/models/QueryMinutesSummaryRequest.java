// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesSummaryRequest extends TeaModel {
    @NameInMap("summaryTypeList")
    public java.util.List<String> summaryTypeList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesSummaryRequest self = new QueryMinutesSummaryRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesSummaryRequest setSummaryTypeList(java.util.List<String> summaryTypeList) {
        this.summaryTypeList = summaryTypeList;
        return this;
    }
    public java.util.List<String> getSummaryTypeList() {
        return this.summaryTypeList;
    }

    public QueryMinutesSummaryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
