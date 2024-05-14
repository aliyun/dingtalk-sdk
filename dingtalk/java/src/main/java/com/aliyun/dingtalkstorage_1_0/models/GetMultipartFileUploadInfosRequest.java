// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetMultipartFileUploadInfosRequest extends TeaModel {
    @NameInMap("option")
    public GetMultipartFileUploadInfosRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("partNumbers")
    public java.util.List<Integer> partNumbers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("uploadKey")
    public String uploadKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetMultipartFileUploadInfosRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMultipartFileUploadInfosRequest self = new GetMultipartFileUploadInfosRequest();
        return TeaModel.build(map, self);
    }

    public GetMultipartFileUploadInfosRequest setOption(GetMultipartFileUploadInfosRequestOption option) {
        this.option = option;
        return this;
    }
    public GetMultipartFileUploadInfosRequestOption getOption() {
        return this.option;
    }

    public GetMultipartFileUploadInfosRequest setPartNumbers(java.util.List<Integer> partNumbers) {
        this.partNumbers = partNumbers;
        return this;
    }
    public java.util.List<Integer> getPartNumbers() {
        return this.partNumbers;
    }

    public GetMultipartFileUploadInfosRequest setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

    public GetMultipartFileUploadInfosRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetMultipartFileUploadInfosRequestOption extends TeaModel {
        @NameInMap("preferIntranet")
        public Boolean preferIntranet;

        public static GetMultipartFileUploadInfosRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetMultipartFileUploadInfosRequestOption self = new GetMultipartFileUploadInfosRequestOption();
            return TeaModel.build(map, self);
        }

        public GetMultipartFileUploadInfosRequestOption setPreferIntranet(Boolean preferIntranet) {
            this.preferIntranet = preferIntranet;
            return this;
        }
        public Boolean getPreferIntranet() {
            return this.preferIntranet;
        }

    }

}
