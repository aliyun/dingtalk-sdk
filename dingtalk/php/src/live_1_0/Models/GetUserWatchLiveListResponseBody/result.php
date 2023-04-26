<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponseBody\result\liveInfoPopModelList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasFinish;

    /**
     * @var liveInfoPopModelList[]
     */
    public $liveInfoPopModelList;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'hasFinish'            => 'hasFinish',
        'liveInfoPopModelList' => 'liveInfoPopModelList',
        'nextToken'            => 'nextToken',
        'total'                => 'total',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
