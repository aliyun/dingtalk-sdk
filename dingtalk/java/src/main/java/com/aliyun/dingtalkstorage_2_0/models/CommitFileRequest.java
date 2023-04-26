// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CommitFileRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("option")
    public CommitFileRequestOption option;

    @NameInMap("uploadKey")
    public String uploadKey;

    @NameInMap("unionId")
    public String unionId;

    public static CommitFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CommitFileRequest self = new CommitFileRequest();
        return TeaModel.build(map, self);
    }

    public CommitFileRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CommitFileRequest setOption(CommitFileRequestOption option) {
        this.option = option;
        return this;
    }
    public CommitFileRequestOption getOption() {
        return this.option;
    }

    public CommitFileRequest setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

    public CommitFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CommitFileRequestOptionAppProperties extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        @NameInMap("visibility")
        public String visibility;

        public static CommitFileRequestOptionAppProperties build(java.util.Map<String, ?> map) throws Exception {
            CommitFileRequestOptionAppProperties self = new CommitFileRequestOptionAppProperties();
            return TeaModel.build(map, self);
        }

        public CommitFileRequestOptionAppProperties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CommitFileRequestOptionAppProperties setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public CommitFileRequestOptionAppProperties setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

    public static class CommitFileRequestOption extends TeaModel {
        @NameInMap("appProperties")
        public java.util.List<CommitFileRequestOptionAppProperties> appProperties;

        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        @NameInMap("convertToOnlineDoc")
        public Boolean convertToOnlineDoc;

        @NameInMap("convertToOnlineDocTargetDocumentType")
        public String convertToOnlineDocTargetDocumentType;

        @NameInMap("size")
        public Long size;

        public static CommitFileRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CommitFileRequestOption self = new CommitFileRequestOption();
            return TeaModel.build(map, self);
        }

        public CommitFileRequestOption setAppProperties(java.util.List<CommitFileRequestOptionAppProperties> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.List<CommitFileRequestOptionAppProperties> getAppProperties() {
            return this.appProperties;
        }

        public CommitFileRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

        public CommitFileRequestOption setConvertToOnlineDoc(Boolean convertToOnlineDoc) {
            this.convertToOnlineDoc = convertToOnlineDoc;
            return this;
        }
        public Boolean getConvertToOnlineDoc() {
            return this.convertToOnlineDoc;
        }

        public CommitFileRequestOption setConvertToOnlineDocTargetDocumentType(String convertToOnlineDocTargetDocumentType) {
            this.convertToOnlineDocTargetDocumentType = convertToOnlineDocTargetDocumentType;
            return this;
        }
        public String getConvertToOnlineDocTargetDocumentType() {
            return this.convertToOnlineDocTargetDocumentType;
        }

        public CommitFileRequestOption setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

}
