<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListResponseBody\result\liveInfoPopModelList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否拉取完成
     *
     * @var bool
     */
    public $hasFinish;

    /**
     * @description 直播详情
     *
     * @var liveInfoPopModelList[]
     */
    public $liveInfoPopModelList;
    protected $_name = [
        'hasFinish'            => 'hasFinish',
        'liveInfoPopModelList' => 'liveInfoPopModelList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasFinish) {
            $res['hasFinish'] = $this->hasFinish;
        }
        if (null !== $this->liveInfoPopModelList) {
            $res['liveInfoPopModelList'] = [];
            if (null !== $this->liveInfoPopModelList && \is_array($this->liveInfoPopModelList)) {
                $n = 0;
                foreach ($this->liveInfoPopModelList as $item) {
                    $res['liveInfoPopModelList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasFinish'])) {
            $model->hasFinish = $map['hasFinish'];
        }
        if (isset($map['liveInfoPopModelList'])) {
            if (!empty($map['liveInfoPopModelList'])) {
                $model->liveInfoPopModelList = [];
                $n                           = 0;
                foreach ($map['liveInfoPopModelList'] as $item) {
                    $model->liveInfoPopModelList[$n++] = null !== $item ? liveInfoPopModelList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
