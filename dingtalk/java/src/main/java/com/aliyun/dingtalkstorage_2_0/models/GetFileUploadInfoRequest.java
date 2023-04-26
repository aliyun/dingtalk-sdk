// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoRequest extends TeaModel {
    @NameInMap("option")
    public GetFileUploadInfoRequestOption option;

    @NameInMap("protocol")
    public String protocol;

    @NameInMap("unionId")
    public String unionId;

    public static GetFileUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoRequest self = new GetFileUploadInfoRequest();
        return TeaModel.build(map, self);
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
        @NameInMap("name")
        public String name;

        @NameInMap("size")
        public Long size;

        public static GetFileUploadInfoRequestOptionPreCheckParam build(java.util.Map<String, ?> map) throws Exception {
            GetFileUploadInfoRequestOptionPreCheckParam self = new GetFileUploadInfoRequestOptionPreCheckParam();
            return TeaModel.build(map, self);
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
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

        @NameInMap("preferIntranet")
        public Boolean preferIntranet;

        @NameInMap("preferRegion")
        public String preferRegion;

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
