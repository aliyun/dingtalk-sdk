// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequest extends TeaModel {
    // 业务数据实例id
    @NameInMap("bizObjectId")
    public String bizObjectId;

    // 文件上传至目标控件的字段名
    @NameInMap("fieldName")
    public String fieldName;

    // 是否覆盖。false=添加，true=覆盖
    @NameInMap("isOverwrite")
    public Boolean isOverwrite;

    // 表单编码
    @NameInMap("schemaCode")
    public String schemaCode;

    public static GetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlRequest self = new GetUploadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetUploadUrlRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public GetUploadUrlRequest setFieldName(String fieldName) {
        this.fieldName = fieldName;
        return this;
    }
    public String getFieldName() {
        return this.fieldName;
    }

    public GetUploadUrlRequest setIsOverwrite(Boolean isOverwrite) {
        this.isOverwrite = isOverwrite;
        return this;
    }
    public Boolean getIsOverwrite() {
        return this.isOverwrite;
    }

    public GetUploadUrlRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
