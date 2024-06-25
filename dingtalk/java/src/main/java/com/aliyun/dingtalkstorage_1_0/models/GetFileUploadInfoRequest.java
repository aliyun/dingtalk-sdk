// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("multipart")
    public Boolean multipart;

    @NameInMap("option")
    public GetFileUploadInfoRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>HEADER_SIGNATURE</p>
     */
    @NameInMap("protocol")
    public String protocol;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetFileUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoRequest self = new GetFileUploadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoRequest setMultipart(Boolean multipart) {
        this.multipart = multipart;
        return this;
    }
    public Boolean getMultipart() {
        return this.multipart;
    }

    public GetFileUploadInfoRequest setOption(GetFileUploadInfoRequestOption option) {
        this.option = option;
        return this;
    }
    public GetFileUploadInfoRequestOption getOption() {
        return this.option;
    }

    public GetFileUploadInfoRequest setProtocol(String protocol) {
        this.protocol = protocol;
        return this;
    }
    public String getProtocol() {
        return this.protocol;
    }

    public GetFileUploadInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetFileUploadInfoRequestOptionPreCheckParam extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>md5</p>
         */
        @NameInMap("md5")
        public String md5;

        /**
         * <strong>example:</strong>
         * <p>dentry_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>parent_id</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <strong>example:</strong>
         * <p>512</p>
         */
        @NameInMap("size")
        public Long size;

        public static GetFileUploadInfoRequestOptionPreCheckParam build(java.util.Map<String, ?> map) throws Exception {
            GetFileUploadInfoRequestOptionPreCheckParam self = new GetFileUploadInfoRequestOptionPreCheckParam();
            return TeaModel.build(map, self);
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setMd5(String md5) {
            this.md5 = md5;
            return this;
        }
        public String getMd5() {
            return this.md5;
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

    public static class GetFileUploadInfoRequestOption extends TeaModel {
        @NameInMap("preCheckParam")
        public GetFileUploadInfoRequestOptionPreCheckParam preCheckParam;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("preferIntranet")
        public Boolean preferIntranet;

        /**
         * <strong>example:</strong>
         * <p>ZHANGJIAKOU</p>
         */
        @NameInMap("preferRegion")
        public String preferRegion;

        /**
         * <strong>example:</strong>
         * <p>DINGTALK</p>
         */
        @NameInMap("storageDriver")
        public String storageDriver;

        public static GetFileUploadInfoRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetFileUploadInfoRequestOption self = new GetFileUploadInfoRequestOption();
            return TeaModel.build(map, self);
        }

        public GetFileUploadInfoRequestOption setPreCheckParam(GetFileUploadInfoRequestOptionPreCheckParam preCheckParam) {
            this.preCheckParam = preCheckParam;
            return this;
        }
        public GetFileUploadInfoRequestOptionPreCheckParam getPreCheckParam() {
            return this.preCheckParam;
        }

        public GetFileUploadInfoRequestOption setPreferIntranet(Boolean preferIntranet) {
            this.preferIntranet = preferIntranet;
            return this;
        }
        public Boolean getPreferIntranet() {
            return this.preferIntranet;
        }

        public GetFileUploadInfoRequestOption setPreferRegion(String preferRegion) {
            this.preferRegion = preferRegion;
            return this;
        }
        public String getPreferRegion() {
            return this.preferRegion;
        }

        public GetFileUploadInfoRequestOption setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

    }

}
