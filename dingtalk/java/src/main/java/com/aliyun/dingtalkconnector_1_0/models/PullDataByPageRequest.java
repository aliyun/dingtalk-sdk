// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPageRequest extends TeaModel {
    @NameInMap("appId")
    public String appId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dataModelId")
    public String dataModelId;

    @NameInMap("datetimeFilterField")
    public String datetimeFilterField;

    @NameInMap("maxDatetime")
    public Long maxDatetime;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("minDatetime")
    public Long minDatetime;

    @NameInMap("nextToken")
    public String nextToken;

    public static PullDataByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPageRequest self = new PullDataByPageRequest();
        return TeaModel.build(map, self);
    }

    public PullDataByPageRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
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

    public PullDataByPageRequest setMaxDatetime(Long maxDatetime) {
        this.maxDatetime = maxDatetime;
        return this;
    }
    public Long getMaxDatetime() {
        return this.maxDatetime;
    }

    public PullDataByPageRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public PullDataByPageRequest setMinDatetime(Long minDatetime) {
        this.minDatetime = minDatetime;
        return this;
    }
    public Long getMinDatetime() {
        return this.minDatetime;
    }

    public PullDataByPageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
