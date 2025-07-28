// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateShortcutRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public CreateShortcutRequestParam param;

    public static CreateShortcutRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateShortcutRequest self = new CreateShortcutRequest();
        return TeaModel.build(map, self);
    }

    public CreateShortcutRequest setParam(CreateShortcutRequestParam param) {
        this.param = param;
        return this;
    }
    public CreateShortcutRequestParam getParam() {
        return this.param;
    }

    public static class CreateShortcutRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("sourceResourceId")
        public String sourceResourceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DENTRY</p>
         */
        @NameInMap("sourceResourceType")
        public String sourceResourceType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("targetResourceId")
        public String targetResourceId;

        /**
         * <strong>example:</strong>
         * <p>123test</p>
         */
        @NameInMap("targetResourceName")
        public String targetResourceName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DENTRY</p>
         */
        @NameInMap("targetResourceType")
        public String targetResourceType;

        public static CreateShortcutRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CreateShortcutRequestParam self = new CreateShortcutRequestParam();
            return TeaModel.build(map, self);
        }

        public CreateShortcutRequestParam setSourceResourceId(String sourceResourceId) {
            this.sourceResourceId = sourceResourceId;
            return this;
        }
        public String getSourceResourceId() {
            return this.sourceResourceId;
        }

        public CreateShortcutRequestParam setSourceResourceType(String sourceResourceType) {
            this.sourceResourceType = sourceResourceType;
            return this;
        }
        public String getSourceResourceType() {
            return this.sourceResourceType;
        }

        public CreateShortcutRequestParam setTargetResourceId(String targetResourceId) {
            this.targetResourceId = targetResourceId;
            return this;
        }
        public String getTargetResourceId() {
            return this.targetResourceId;
        }

        public CreateShortcutRequestParam setTargetResourceName(String targetResourceName) {
            this.targetResourceName = targetResourceName;
            return this;
        }
        public String getTargetResourceName() {
            return this.targetResourceName;
        }

        public CreateShortcutRequestParam setTargetResourceType(String targetResourceType) {
            this.targetResourceType = targetResourceType;
            return this;
        }
        public String getTargetResourceType() {
            return this.targetResourceType;
        }

    }

}
