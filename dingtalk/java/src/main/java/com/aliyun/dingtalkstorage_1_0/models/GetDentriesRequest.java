// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentriesRequest extends TeaModel {
    // 文件(夹)id列表
    // 最大size:
    // 	30
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    // 可选参数
    @NameInMap("option")
    public GetDentriesRequestOption option;

    // 用户id
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
        // 通过指定应用id, 返回对应的可见属性，即dentry.appProperties，
        // 默认都会返回当前应用的属性，
        // 如不指定appIds, 则默认返回当前应用的appProperties
        // 最大size:
        // 	20
        @NameInMap("appIdsForAppProperties")
        public java.util.List<String> appIdsForAppProperties;

        // 是否获取文件缩略图临时链接
        // 注: 按需获取, 会影响接口耗时
        // 默认值:
        // 	false
        @NameInMap("withThumbnail")
        public Boolean withThumbnail;

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

        public GetDentriesRequestOption setWithThumbnail(Boolean withThumbnail) {
            this.withThumbnail = withThumbnail;
            return this;
        }
        public Boolean getWithThumbnail() {
            return this.withThumbnail;
        }

    }

}
