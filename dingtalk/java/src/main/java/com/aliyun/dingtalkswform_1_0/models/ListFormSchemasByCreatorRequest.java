// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormSchemasByCreatorRequest extends TeaModel {
    // 填表类型。0表示通用填表，1表示教育版填表
    @NameInMap("bizType")
    public Integer bizType;

    // 填表创建人userid
    @NameInMap("creator")
    public String creator;

    // 分页大小，最大200
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标，从0开始。后续取返回结果中nextToken的值。
    @NameInMap("nextToken")
    public Long nextToken;

    public static ListFormSchemasByCreatorRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFormSchemasByCreatorRequest self = new ListFormSchemasByCreatorRequest();
        return TeaModel.build(map, self);
    }

    public ListFormSchemasByCreatorRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public ListFormSchemasByCreatorRequest setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public ListFormSchemasByCreatorRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFormSchemasByCreatorRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
