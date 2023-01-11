// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public GetFileDownloadInfoRequestOption option;

    /**
     * <p>用户id</p>
     */
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
        /**
         * <p>优先使用内网传输</p>
         * <p>前提: 配置了专属存储内网传输</p>
         * <p>默认值:</p>
         * <p>	true</p>
         */
        @NameInMap("preferIntranet")
        public Boolean preferIntranet;

        /**
         * <p>历史版本号</p>
         */
        @NameInMap("version")
        public Long version;

        public static GetFileDownloadInfoRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadInfoRequestOption self = new GetFileDownloadInfoRequestOption();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadInfoRequestOption setPreferIntranet(Boolean preferIntranet) {
            this.preferIntranet = preferIntranet;
            return this;
        }
        public Boolean getPreferIntranet() {
            return this.preferIntranet;
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
