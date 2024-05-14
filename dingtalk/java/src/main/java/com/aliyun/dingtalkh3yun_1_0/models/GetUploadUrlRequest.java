// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldName")
    public String fieldName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isOverwrite")
    public Boolean isOverwrite;

    /**
     * <p>This parameter is required.</p>
     */
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
