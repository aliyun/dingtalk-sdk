// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryRequest extends TeaModel {
    @NameInMap("option")
    public GetDentryRequestOption option;

    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("appIdsForAppProperties")
        public java.util.List<String> appIdsForAppProperties;

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
