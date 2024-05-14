// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryOpenInfoRequest extends TeaModel {
    @NameInMap("option")
    public GetDentryOpenInfoRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetDentryOpenInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentryOpenInfoRequest self = new GetDentryOpenInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetDentryOpenInfoRequest setOption(GetDentryOpenInfoRequestOption option) {
        this.option = option;
        return this;
    }
    public GetDentryOpenInfoRequestOption getOption() {
        return this.option;
    }

    public GetDentryOpenInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetDentryOpenInfoRequestOption extends TeaModel {
        @NameInMap("checkLogin")
        public Boolean checkLogin;

        @NameInMap("type")
        public String type;

        @NameInMap("version")
        public Long version;

        @NameInMap("waterMark")
        public Boolean waterMark;

        public static GetDentryOpenInfoRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetDentryOpenInfoRequestOption self = new GetDentryOpenInfoRequestOption();
            return TeaModel.build(map, self);
        }

        public GetDentryOpenInfoRequestOption setCheckLogin(Boolean checkLogin) {
            this.checkLogin = checkLogin;
            return this;
        }
        public Boolean getCheckLogin() {
            return this.checkLogin;
        }

        public GetDentryOpenInfoRequestOption setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetDentryOpenInfoRequestOption setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

        public GetDentryOpenInfoRequestOption setWaterMark(Boolean waterMark) {
            this.waterMark = waterMark;
            return this;
        }
        public Boolean getWaterMark() {
            return this.waterMark;
        }

    }

}
