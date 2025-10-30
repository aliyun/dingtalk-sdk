// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class GetLoginUserResponseBody extends TeaModel {
    @NameInMap("commodityInfo")
    public GetLoginUserResponseBodyCommodityInfo commodityInfo;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("openId")
    public String openId;

    @NameInMap("unionId")
    public String unionId;

    public static GetLoginUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLoginUserResponseBody self = new GetLoginUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLoginUserResponseBody setCommodityInfo(GetLoginUserResponseBodyCommodityInfo commodityInfo) {
        this.commodityInfo = commodityInfo;
        return this;
    }
    public GetLoginUserResponseBodyCommodityInfo getCommodityInfo() {
        return this.commodityInfo;
    }

    public GetLoginUserResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetLoginUserResponseBody setOpenId(String openId) {
        this.openId = openId;
        return this;
    }
    public String getOpenId() {
        return this.openId;
    }

    public GetLoginUserResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetLoginUserResponseBodyCommodityInfo extends TeaModel {
        @NameInMap("version")
        public String version;

        public static GetLoginUserResponseBodyCommodityInfo build(java.util.Map<String, ?> map) throws Exception {
            GetLoginUserResponseBodyCommodityInfo self = new GetLoginUserResponseBodyCommodityInfo();
            return TeaModel.build(map, self);
        }

        public GetLoginUserResponseBodyCommodityInfo setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
