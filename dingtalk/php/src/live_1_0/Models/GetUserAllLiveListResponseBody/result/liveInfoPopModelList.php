<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListResponseBody\result\liveInfoPopModelList\extraInfo;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListResponseBody\result\liveInfoPopModelList\liveBasicInfo;
use AlibabaCloud\Tea\Model;

class liveInfoPopModelList extends Model
{
    /**
     * @description 直播额外信息
     *
     * @var extraInfo
     */
    public $extraInfo;

    /**
     * @description 直播基础信息
     *
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
