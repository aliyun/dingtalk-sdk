<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListResponseBody\result\liveInfoPopModelList\hasSubscribed;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListResponseBody\result\liveInfoPopModelList\liveBasicInfo;
use AlibabaCloud\Tea\Model;

class liveInfoPopModelList extends Model
{
    /**
     * @description 直播额外信息
     *
     * @var hasSubscribed
     */
    public $hasSubscribed;

    /**
     * @description 直播基础信息
     *
     * @var liveBasicInfo
     */
    public $liveBasicInfo;
    protected $_name = [
        'hasSubscribed' => 'hasSubscribed',
        'liveBasicInfo' => 'liveBasicInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasSubscribed) {
            $res['hasSubscribed'] = null !== $this->hasSubscribed ? $this->hasSubscribed->toMap() : null;
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
        if (isset($map['hasSubscribed'])) {
            $model->hasSubscribed = hasSubscribed::fromMap($map['hasSubscribed']);
        }
        if (isset($map['liveBasicInfo'])) {
            $model->liveBasicInfo = liveBasicInfo::fromMap($map['liveBasicInfo']);
        }

        return $model;
    }
}
