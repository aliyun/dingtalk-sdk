// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class SearchResidentRequest extends TeaModel {
    @NameInMap("residentCropId")
    public String residentCropId;

    @NameInMap("searchWord")
    public String searchWord;

    public static SearchResidentRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchResidentRequest self = new SearchResidentRequest();
        return TeaModel.build(map, self);
    }

    public SearchResidentRequest setResidentCropId(String residentCropId) {
        this.residentCropId = residentCropId;
        return this;
    }
    public String getResidentCropId() {
        return this.residentCropId;
    }

    public SearchResidentRequest setSearchWord(String searchWord) {
        this.searchWord = searchWord;
        return this;
    }
    public String getSearchWord() {
        return this.searchWord;
    }

}
