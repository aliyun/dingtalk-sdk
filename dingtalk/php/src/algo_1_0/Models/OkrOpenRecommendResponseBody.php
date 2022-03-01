<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems;
use AlibabaCloud\Tea\Model;

class OkrOpenRecommendResponseBody extends Model
{
    /**
     * @description okrRecommendItems
     *
     * @var okrRecommendItems[]
     */
    public $okrRecommendItems;

    /**
     * @description requestId
     *
     * @var string
     */
    public $requestId;
    protected $_name = [
        'okrRecommendItems' => 'okrRecommendItems',
        'requestId'         => 'requestId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->okrRecommendItems) {
            $res['okrRecommendItems'] = [];
            if (null !== $this->okrRecommendItems && \is_array($this->okrRecommendItems)) {
                $n = 0;
                foreach ($this->okrRecommendItems as $item) {
                    $res['okrRecommendItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OkrOpenRecommendResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['okrRecommendItems'])) {
            if (!empty($map['okrRecommendItems'])) {
                $model->okrRecommendItems = [];
                $n                        = 0;
                foreach ($map['okrRecommendItems'] as $item) {
                    $model->okrRecommendItems[$n++] = null !== $item ? okrRecommendItems::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
