// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertBizObjectRequest extends TeaModel {
    // 表单编码
    @NameInMap("schemaCode")
    public String schemaCode;

    // 操作用户id
    @NameInMap("opUserId")
    public String opUserId;

    // 待新增的业对象json数组
    @NameInMap("bizObjectJsonArray")
    public java.util.List<String> bizObjectJsonArray;

    // 是否是草稿数据。true=创建草稿数据，false=创建生效数据
    @NameInMap("isDraft")
    public Boolean isDraft;

    public static BatchInsertBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchInsertBizObjectRequest self = new BatchInsertBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public BatchInsertBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

    public BatchInsertBizObjectRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
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

}
