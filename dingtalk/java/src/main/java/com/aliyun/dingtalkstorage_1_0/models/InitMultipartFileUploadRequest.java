// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class InitMultipartFileUploadRequest extends TeaModel {
    @NameInMap("option")
    public InitMultipartFileUploadRequestOption option;

    @NameInMap("unionId")
    public String unionId;

    public static InitMultipartFileUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        InitMultipartFileUploadRequest self = new InitMultipartFileUploadRequest();
        return TeaModel.build(map, self);
    }

    public InitMultipartFileUploadRequest setOption(InitMultipartFileUploadRequestOption option) {
        this.option = option;
        return this;
    }
    public InitMultipartFileUploadRequestOption getOption() {
        return this.option;
    }

    public InitMultipartFileUploadRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class InitMultipartFileUploadRequestOptionPreCheckParam extends TeaModel {
        @NameInMap("md5")
        public String md5;

        @NameInMap("name")
        public String name;

        @NameInMap("parentId")
        public String parentId;

        @NameInMap("size")
        public Long size;

        public static InitMultipartFileUploadRequestOptionPreCheckParam build(java.util.Map<String, ?> map) throws Exception {
            InitMultipartFileUploadRequestOptionPreCheckParam self = new InitMultipartFileUploadRequestOptionPreCheckParam();
            return TeaModel.build(map, self);
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setMd5(String md5) {
            this.md5 = md5;
            return this;
        }
        public String getMd5() {
            return this.md5;
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

    public static class InitMultipartFileUploadRequestOption extends TeaModel {
        @NameInMap("preCheckParam")
        public InitMultipartFileUploadRequestOptionPreCheckParam preCheckParam;

        @NameInMap("preferRegion")
        public String preferRegion;

        @NameInMap("storageDriver")
        public String storageDriver;

        public static InitMultipartFileUploadRequestOption build(java.util.Map<String, ?> map) throws Exception {
            InitMultipartFileUploadRequestOption self = new InitMultipartFileUploadRequestOption();
            return TeaModel.build(map, self);
        }

        public InitMultipartFileUploadRequestOption setPreCheckParam(InitMultipartFileUploadRequestOptionPreCheckParam preCheckParam) {
            this.preCheckParam = preCheckParam;
            return this;
        }
        public InitMultipartFileUploadRequestOptionPreCheckParam getPreCheckParam() {
            return this.preCheckParam;
        }

        public InitMultipartFileUploadRequestOption setPreferRegion(String preferRegion) {
            this.preferRegion = preferRegion;
            return this;
        }
        public String getPreferRegion() {
            return this.preferRegion;
        }

        public InitMultipartFileUploadRequestOption setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

    }

}
