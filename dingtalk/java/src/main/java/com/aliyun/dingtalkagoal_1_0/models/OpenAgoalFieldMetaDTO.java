// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalFieldMetaDTO extends TeaModel {
    /**
     * <p>是否启用</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <p>字段元数据别名</p>
     * 
     * <strong>example:</strong>
     * <p>字段别名</p>
     */
    @NameInMap("alias")
    public String alias;

    /**
     * <p>字段元数据标识</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>foo</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>实体类型</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OBJECTIVE</p>
     */
    @NameInMap("entityType")
    public String entityType;

    /**
     * <p>字段ID</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcxxxxx</p>
     */
    @NameInMap("fieldId")
    public String fieldId;

    /**
     * <p>字段备注</p>
     * 
     * <strong>example:</strong>
     * <p>字段备注</p>
     */
    @NameInMap("note")
    public String note;

    /**
     * <p>字段数据来源</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OPEN</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>字段元数据名称</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>字段名</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>字段类型</p>
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>string</p>
     */
    @NameInMap("type")
    public String type;

    public static OpenAgoalFieldMetaDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalFieldMetaDTO self = new OpenAgoalFieldMetaDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalFieldMetaDTO setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
    }

    public OpenAgoalFieldMetaDTO setAlias(String alias) {
        this.alias = alias;
        return this;
    }
    public String getAlias() {
        return this.alias;
    }

    public OpenAgoalFieldMetaDTO setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public OpenAgoalFieldMetaDTO setEntityType(String entityType) {
        this.entityType = entityType;
        return this;
    }
    public String getEntityType() {
        return this.entityType;
    }

    public OpenAgoalFieldMetaDTO setFieldId(String fieldId) {
        this.fieldId = fieldId;
        return this;
    }
    public String getFieldId() {
        return this.fieldId;
    }

    public OpenAgoalFieldMetaDTO setNote(String note) {
        this.note = note;
        return this;
    }
    public String getNote() {
        return this.note;
    }

    public OpenAgoalFieldMetaDTO setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public OpenAgoalFieldMetaDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenAgoalFieldMetaDTO setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
