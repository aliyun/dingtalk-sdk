// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalFieldUpdateRequest extends TeaModel {
    @NameInMap("body")
    public AgoalFieldUpdateRequestBody body;

    public static AgoalFieldUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalFieldUpdateRequest self = new AgoalFieldUpdateRequest();
        return TeaModel.build(map, self);
    }

    public AgoalFieldUpdateRequest setBody(AgoalFieldUpdateRequestBody body) {
        this.body = body;
        return this;
    }
    public AgoalFieldUpdateRequestBody getBody() {
        return this.body;
    }

    public static class AgoalFieldUpdateRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>662e006fe4b0f579bbcxxxxx</p>
         */
        @NameInMap("entityId")
        public String entityId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>OBJECTIVE</p>
         */
        @NameInMap("entityType")
        public String entityType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>title</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>字段值</p>
         */
        @NameInMap("value")
        public String value;

        public static AgoalFieldUpdateRequestBody build(java.util.Map<String, ?> map) throws Exception {
            AgoalFieldUpdateRequestBody self = new AgoalFieldUpdateRequestBody();
            return TeaModel.build(map, self);
        }

        public AgoalFieldUpdateRequestBody setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public AgoalFieldUpdateRequestBody setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AgoalFieldUpdateRequestBody setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public AgoalFieldUpdateRequestBody setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
