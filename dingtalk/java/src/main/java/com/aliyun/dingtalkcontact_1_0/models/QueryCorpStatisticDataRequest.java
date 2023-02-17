// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpStatisticDataRequest extends TeaModel {
    /**
     * <p>结束时间（yyyymmdd）</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <p>开始时间（yyyymmdd）</p>
     */
    @NameInMap("startTime")
    public String startTime;

    /**
     * <p>模版id列表</p>
     */
    @NameInMap("templateIds")
    public java.util.List<String> templateIds;

    /**
     * <p>操作者id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryCorpStatisticDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpStatisticDataRequest self = new QueryCorpStatisticDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryCorpStatisticDataRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public QueryCorpStatisticDataRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public QueryCorpStatisticDataRequest setTemplateIds(java.util.List<String> templateIds) {
        this.templateIds = templateIds;
        return this;
    }
    public java.util.List<String> getTemplateIds() {
        return this.templateIds;
    }

    public QueryCorpStatisticDataRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
