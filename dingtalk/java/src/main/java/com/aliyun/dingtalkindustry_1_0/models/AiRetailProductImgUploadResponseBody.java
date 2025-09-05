// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductImgUploadResponseBody extends TeaModel {
    @NameInMap("result")
    public AiRetailProductImgUploadResponseBodyResult result;

    public static AiRetailProductImgUploadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductImgUploadResponseBody self = new AiRetailProductImgUploadResponseBody();
        return TeaModel.build(map, self);
    }

    public AiRetailProductImgUploadResponseBody setResult(AiRetailProductImgUploadResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AiRetailProductImgUploadResponseBodyResult getResult() {
        return this.result;
    }

    public static class AiRetailProductImgUploadResponseBodyResult extends TeaModel {
        @NameInMap("ossFileId")
        public String ossFileId;

        @NameInMap("ossUploadUrl")
        public String ossUploadUrl;

        public static AiRetailProductImgUploadResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AiRetailProductImgUploadResponseBodyResult self = new AiRetailProductImgUploadResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AiRetailProductImgUploadResponseBodyResult setOssFileId(String ossFileId) {
            this.ossFileId = ossFileId;
            return this;
        }
        public String getOssFileId() {
            return this.ossFileId;
        }

        public AiRetailProductImgUploadResponseBodyResult setOssUploadUrl(String ossUploadUrl) {
            this.ossUploadUrl = ossUploadUrl;
            return this;
        }
        public String getOssUploadUrl() {
            return this.ossUploadUrl;
        }

    }

}
