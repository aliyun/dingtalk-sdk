// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertBizObjectRequest extends TeaModel {
    @NameInMap("bizObjectJsonArray")
    public java.util.List<String> bizObjectJsonArray;

    @NameInMap("isDraft")
    public Boolean isDraft;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("schemaCode")
    public String schemaCode;

    public static BatchInsertBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchInsertBizObjectRequest self = new BatchInsertBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public BatchInsertBizObjectRequest setBizObjectJsonArray(java.util.List<String> bizObjectJsonArray) {
        this.bizObjectJsonArray = bizObjectJsonArray;
        return this;
    }
    public java.util.List<String> getBizObjectJsonArray() {
        return this.bizObjectJsonArray;
    }

    public BatchInsertBizObjectRequest setIsDraft(Boolean isDraft) {
        this.isDraft = isDraft;
        return this;
    }
    public Boolean getIsDraft() {
        return this.isDraft;
    }

    public BatchInsertBizObjectRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public BatchInsertBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
