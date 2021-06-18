// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPageRequest extends TeaModel {
    // 要拉取的主数据模型id。
    @NameInMap("dataModelId")
    public String dataModelId;

    // 用于过滤时间范围的字段，包含数据创建时间(dataGmtCreate)和数据修改时间(dataGmtModified)，如不传则不过滤。
    @NameInMap("datetimeFilterField")
    public String datetimeFilterField;

    // 当配置了datetimeFilterField字段后，数据的时间起点，如果不传则将最早一条数据作为起点。
    @NameInMap("minDatetime")
    public Long minDatetime;

    // 当配置了datetimeFilterField字段后，数据的时间终点，如果不传则按最新一条数据作为终点。
    @NameInMap("maxDatetime")
    public Long maxDatetime;

    // 用于翻页的游标，如果为空则从第一条数据开始查询。
    @NameInMap("nextToken")
    public String nextToken;

    // 单次获取的最大记录条数，最大限制100条。
    @NameInMap("maxResults")
    public Long maxResults;

    public static PullDataByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPageRequest self = new PullDataByPageRequest();
        return TeaModel.build(map, self);
    }

    public PullDataByPageRequest setDataModelId(String dataModelId) {
        this.dataModelId = dataModelId;
        return this;
    }
    public String getDataModelId() {
        return this.dataModelId;
    }

    public PullDataByPageRequest setDatetimeFilterField(String datetimeFilterField) {
        this.datetimeFilterField = datetimeFilterField;
        return this;
    }
    public String getDatetimeFilterField() {
        return this.datetimeFilterField;
    }

    public PullDataByPageRequest setMinDatetime(Long minDatetime) {
        this.minDatetime = minDatetime;
        return this;
    }
    public Long getMinDatetime() {
        return this.minDatetime;
    }

    public PullDataByPageRequest setMaxDatetime(Long maxDatetime) {
        this.maxDatetime = maxDatetime;
        return this;
    }
    public Long getMaxDatetime() {
        return this.maxDatetime;
    }

    public PullDataByPageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PullDataByPageRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

}
