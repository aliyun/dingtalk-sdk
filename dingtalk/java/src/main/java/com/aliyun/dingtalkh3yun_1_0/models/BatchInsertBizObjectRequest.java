// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertBizObjectRequest extends TeaModel {
    /**
     * <p>待新增的业对象json数组</p>
     */
    @NameInMap("bizObjectJsonArray")
    public java.util.List<String> bizObjectJsonArray;

    /**
     * <p>是否是草稿数据。true=创建草稿数据，false=创建生效数据</p>
     */
    @NameInMap("isDraft")
    public Boolean isDraft;

    /**
     * <p>操作用户id</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>表单编码</p>
     */
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
