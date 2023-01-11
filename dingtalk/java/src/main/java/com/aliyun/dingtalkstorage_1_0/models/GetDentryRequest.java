// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public GetDentryRequestOption option;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentryRequest self = new GetDentryRequest();
        return TeaModel.build(map, self);
    }

    public GetDentryRequest setOption(GetDentryRequestOption option) {
        this.option = option;
        return this;
    }
    public GetDentryRequestOption getOption() {
        return this.option;
    }

    public GetDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetDentryRequestOption extends TeaModel {
        /**
         * <p>通过指定应用id, 返回对应的可见属性，即dentry.appProperties，</p>
         * <p>默认都会返回当前应用的属性，</p>
         * <p>如不指定appIds, 则默认返回当前应用的appProperties</p>
         * <p>最大size:</p>
         * <p>	20</p>
         */
        @NameInMap("appIdsForAppProperties")
        public java.util.List<String> appIdsForAppProperties;

        /**
         * <p>是否获取文件缩略图临时链接</p>
         * <p>注: 按需获取, 会影响接口耗时</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withThumbnail")
        public Boolean withThumbnail;

        public static GetDentryRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetDentryRequestOption self = new GetDentryRequestOption();
            return TeaModel.build(map, self);
        }

        public GetDentryRequestOption setAppIdsForAppProperties(java.util.List<String> appIdsForAppProperties) {
            this.appIdsForAppProperties = appIdsForAppProperties;
            return this;
        }
        public java.util.List<String> getAppIdsForAppProperties() {
            return this.appIdsForAppProperties;
        }

        public GetDentryRequestOption setWithThumbnail(Boolean withThumbnail) {
            this.withThumbnail = withThumbnail;
            return this;
        }
        public Boolean getWithThumbnail() {
            return this.withThumbnail;
        }

    }

}
