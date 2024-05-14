// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetNodeByUrlRequest extends TeaModel {
    @NameInMap("option")
    public GetNodeByUrlRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetNodeByUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNodeByUrlRequest self = new GetNodeByUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetNodeByUrlRequest setOption(GetNodeByUrlRequestOption option) {
        this.option = option;
        return this;
    }
    public GetNodeByUrlRequestOption getOption() {
        return this.option;
    }

    public GetNodeByUrlRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public GetNodeByUrlRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class GetNodeByUrlRequestOption extends TeaModel {
        @NameInMap("withPermissionRole")
        public Boolean withPermissionRole;

        @NameInMap("withStatisticalInfo")
        public Boolean withStatisticalInfo;

        public static GetNodeByUrlRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetNodeByUrlRequestOption self = new GetNodeByUrlRequestOption();
            return TeaModel.build(map, self);
        }

        public GetNodeByUrlRequestOption setWithPermissionRole(Boolean withPermissionRole) {
            this.withPermissionRole = withPermissionRole;
            return this;
        }
        public Boolean getWithPermissionRole() {
            return this.withPermissionRole;
        }

        public GetNodeByUrlRequestOption setWithStatisticalInfo(Boolean withStatisticalInfo) {
            this.withStatisticalInfo = withStatisticalInfo;
            return this;
        }
        public Boolean getWithStatisticalInfo() {
            return this.withStatisticalInfo;
        }

    }

}
