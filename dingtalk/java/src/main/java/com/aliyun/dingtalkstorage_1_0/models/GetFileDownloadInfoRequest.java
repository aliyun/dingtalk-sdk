// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public GetFileDownloadInfoRequestOption option;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetFileDownloadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoRequest self = new GetFileDownloadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoRequest setOption(GetFileDownloadInfoRequestOption option) {
        this.option = option;
        return this;
    }
    public GetFileDownloadInfoRequestOption getOption() {
        return this.option;
    }

    public GetFileDownloadInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetFileDownloadInfoRequestOption extends TeaModel {
        // 历史版本号
        @NameInMap("version")
        public Long version;

        public static GetFileDownloadInfoRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadInfoRequestOption self = new GetFileDownloadInfoRequestOption();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadInfoRequestOption setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
