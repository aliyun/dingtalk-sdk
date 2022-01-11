// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListRobotRequest extends TeaModel {
    // 查询的企业Id
    @NameInMap("corpId")
    public String corpId;

    // 本次读取的最大数据记录数量
    @NameInMap("maxResults")
    public Integer maxResults;

    // 用来标记当前开始读取的位置，置空表示从头开始
    @NameInMap("nextToken")
    public Long nextToken;

    // 多实例ID
    @NameInMap("openInstanceId")
    public String openInstanceId;

    // 产品类型
    @NameInMap("productionType")
    public Integer productionType;

    public static PageListRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListRobotRequest self = new PageListRobotRequest();
        return TeaModel.build(map, self);
    }

    public PageListRobotRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public PageListRobotRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public PageListRobotRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public PageListRobotRequest setOpenInstanceId(String openInstanceId) {
        this.openInstanceId = openInstanceId;
        return this;
    }
    public String getOpenInstanceId() {
        return this.openInstanceId;
    }

    public PageListRobotRequest setProductionType(Integer productionType) {
        this.productionType = productionType;
        return this;
    }
    public Integer getProductionType() {
        return this.productionType;
    }

}
