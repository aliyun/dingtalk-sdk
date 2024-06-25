// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Image</p>
     */
    @NameInMap("fieldName")
    public String fieldName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isOverwrite")
    public Boolean isOverwrite;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001833abb0fb61524487eb01848207bc89b47</p>
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
