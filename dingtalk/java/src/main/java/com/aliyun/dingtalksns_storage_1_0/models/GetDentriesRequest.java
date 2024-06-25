// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetDentriesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    @NameInMap("option")
    public GetDentriesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentriesRequest self = new GetDentriesRequest();
        return TeaModel.build(map, self);
    }

    public GetDentriesRequest setDentryIds(java.util.List<String> dentryIds) {
        this.dentryIds = dentryIds;
        return this;
    }
    public java.util.List<String> getDentryIds() {
        return this.dentryIds;
    }

    public GetDentriesRequest setOption(GetDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public GetDentriesRequestOption getOption() {
        return this.option;
    }

    public GetDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetDentriesRequestOption extends TeaModel {
        @NameInMap("appIdsForAppProperties")
        public java.util.List<String> appIdsForAppProperties;

        public static GetDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetDentriesRequestOption self = new GetDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public GetDentriesRequestOption setAppIdsForAppProperties(java.util.List<String> appIdsForAppProperties) {
            this.appIdsForAppProperties = appIdsForAppProperties;
            return this;
        }
        public java.util.List<String> getAppIdsForAppProperties() {
            return this.appIdsForAppProperties;
        }

    }

}
