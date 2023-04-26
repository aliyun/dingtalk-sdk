// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentriesRequest extends TeaModel {
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    @NameInMap("option")
    public DeleteDentriesRequestOption option;

    @NameInMap("unionId")
    public String unionId;

    public static DeleteDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentriesRequest self = new DeleteDentriesRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDentriesRequest setDentryIds(java.util.List<String> dentryIds) {
        this.dentryIds = dentryIds;
        return this;
    }
    public java.util.List<String> getDentryIds() {
        return this.dentryIds;
    }

    public DeleteDentriesRequest setOption(DeleteDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public DeleteDentriesRequestOption getOption() {
        return this.option;
    }

    public DeleteDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class DeleteDentriesRequestOption extends TeaModel {
        @NameInMap("toRecycleBin")
        public Boolean toRecycleBin;

        public static DeleteDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            DeleteDentriesRequestOption self = new DeleteDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public DeleteDentriesRequestOption setToRecycleBin(Boolean toRecycleBin) {
            this.toRecycleBin = toRecycleBin;
            return this;
        }
        public Boolean getToRecycleBin() {
            return this.toRecycleBin;
        }

    }

}
