// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ExecuteImportRequest extends TeaModel {
    @NameInMap("appendConfig")
    public ExecuteImportRequestAppendConfig appendConfig;

    @NameInMap("encryption")
    public ExecuteImportRequestEncryption encryption;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("importId")
    public String importId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ExecuteImportRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteImportRequest self = new ExecuteImportRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteImportRequest setAppendConfig(ExecuteImportRequestAppendConfig appendConfig) {
        this.appendConfig = appendConfig;
        return this;
    }
    public ExecuteImportRequestAppendConfig getAppendConfig() {
        return this.appendConfig;
    }

    public ExecuteImportRequest setEncryption(ExecuteImportRequestEncryption encryption) {
        this.encryption = encryption;
        return this;
    }
    public ExecuteImportRequestEncryption getEncryption() {
        return this.encryption;
    }

    public ExecuteImportRequest setImportId(String importId) {
        this.importId = importId;
        return this;
    }
    public String getImportId() {
        return this.importId;
    }

    public ExecuteImportRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class ExecuteImportRequestAppendConfig extends TeaModel {
        @NameInMap("fieldIdMapping")
        public java.util.Map<String, String> fieldIdMapping;

        @NameInMap("fieldMapping")
        public java.util.Map<String, String> fieldMapping;

        @NameInMap("headerRow")
        public Integer headerRow;

        @NameInMap("srcSheetName")
        public String srcSheetName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tableId")
        public String tableId;

        public static ExecuteImportRequestAppendConfig build(java.util.Map<String, ?> map) throws Exception {
            ExecuteImportRequestAppendConfig self = new ExecuteImportRequestAppendConfig();
            return TeaModel.build(map, self);
        }

        public ExecuteImportRequestAppendConfig setFieldIdMapping(java.util.Map<String, String> fieldIdMapping) {
            this.fieldIdMapping = fieldIdMapping;
            return this;
        }
        public java.util.Map<String, String> getFieldIdMapping() {
            return this.fieldIdMapping;
        }

        public ExecuteImportRequestAppendConfig setFieldMapping(java.util.Map<String, String> fieldMapping) {
            this.fieldMapping = fieldMapping;
            return this;
        }
        public java.util.Map<String, String> getFieldMapping() {
            return this.fieldMapping;
        }

        public ExecuteImportRequestAppendConfig setHeaderRow(Integer headerRow) {
            this.headerRow = headerRow;
            return this;
        }
        public Integer getHeaderRow() {
            return this.headerRow;
        }

        public ExecuteImportRequestAppendConfig setSrcSheetName(String srcSheetName) {
            this.srcSheetName = srcSheetName;
            return this;
        }
        public String getSrcSheetName() {
            return this.srcSheetName;
        }

        public ExecuteImportRequestAppendConfig setTableId(String tableId) {
            this.tableId = tableId;
            return this;
        }
        public String getTableId() {
            return this.tableId;
        }

    }

    public static class ExecuteImportRequestEncryption extends TeaModel {
        @NameInMap("algorithm")
        public String algorithm;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("encryptedAesKey")
        public String encryptedAesKey;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("iv")
        public String iv;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("keyVersion")
        public String keyVersion;

        public static ExecuteImportRequestEncryption build(java.util.Map<String, ?> map) throws Exception {
            ExecuteImportRequestEncryption self = new ExecuteImportRequestEncryption();
            return TeaModel.build(map, self);
        }

        public ExecuteImportRequestEncryption setAlgorithm(String algorithm) {
            this.algorithm = algorithm;
            return this;
        }
        public String getAlgorithm() {
            return this.algorithm;
        }

        public ExecuteImportRequestEncryption setEncryptedAesKey(String encryptedAesKey) {
            this.encryptedAesKey = encryptedAesKey;
            return this;
        }
        public String getEncryptedAesKey() {
            return this.encryptedAesKey;
        }

        public ExecuteImportRequestEncryption setIv(String iv) {
            this.iv = iv;
            return this;
        }
        public String getIv() {
            return this.iv;
        }

        public ExecuteImportRequestEncryption setKeyVersion(String keyVersion) {
            this.keyVersion = keyVersion;
            return this;
        }
        public String getKeyVersion() {
            return this.keyVersion;
        }

    }

}
