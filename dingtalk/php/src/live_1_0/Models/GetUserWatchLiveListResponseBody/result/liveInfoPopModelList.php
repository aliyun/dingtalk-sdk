<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponseBody\result\liveInfoPopModelList\extraInfo;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponseBody\result\liveInfoPopModelList\liveBasicInfo;
use AlibabaCloud\Tea\Model;

class liveInfoPopModelList extends Model
{
    /**
     * @var extraInfo
     */
    public $extraInfo;

    /**
     * @var liveBasicInfo
     */
    public $liveBasicInfo;
    protected $_name = [
        'extraInfo'     => 'extraInfo',
        'liveBasicInfo' => 'liveBasicInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extraInfo) {
            $res['extraInfo'] = null !== $this->extraInfo ? $this->extraInfo->toMap() : null;
        }
        if (null !== $this->liveBasicInfo) {
            $res['liveBasicInfo'] = null !== $this->liveBasicInfo ? $this->liveBasicInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveInfoPopModelList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extraInfo'])) {
            $model->extraInfo = extraInfo::fromMap($map['extraInfo']);
        }
        if (isset($map['liveBasicInfo'])) {
            $model->liveBasicInfo = liveBasicInfo::fromMap($map['liveBasicInfo']);
        }

        return $model;
    }
}
