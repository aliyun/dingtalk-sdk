// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceResponseBody extends TeaModel {
    /**
     * <p>IM会话存储空间信息</p>
     */
    @NameInMap("space")
    public GetSpaceResponseBodySpace space;

    public static GetSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceResponseBody self = new GetSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpaceResponseBody setSpace(GetSpaceResponseBodySpace space) {
        this.space = space;
        return this;
    }
    public GetSpaceResponseBodySpace getSpace() {
        return this.space;
    }

    public static class GetSpaceResponseBodySpace extends TeaModel {
        /**
         * <p>空间归属企业的id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <p>空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        public static GetSpaceResponseBodySpace build(java.util.Map<String, ?> map) throws Exception {
            GetSpaceResponseBodySpace self = new GetSpaceResponseBodySpace();
            return TeaModel.build(map, self);
        }

        public GetSpaceResponseBodySpace setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetSpaceResponseBodySpace setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetSpaceResponseBodySpace setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetSpaceResponseBodySpace setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
