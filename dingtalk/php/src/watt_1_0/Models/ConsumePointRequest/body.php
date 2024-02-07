<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointRequest;

use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointRequest\body\consumeDetail;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var consumeDetail
     */
    public $consumeDetail;

    /**
     * @var string
     */
    public $pointPoolCode;

    /**
     * @var int
     */
    public $points;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'consumeDetail' => 'consumeDetail',
        'pointPoolCode' => 'pointPoolCode',
        'points'        => 'points',
        'requestId'     => 'requestId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->consumeDetail) {
            $res['consumeDetail'] = null !== $this->consumeDetail ? $this->consumeDetail->toMap() : null;
        }
        if (null !== $this->pointPoolCode) {
            $res['pointPoolCode'] = $this->pointPoolCode;
        }
        if (null !== $this->points) {
            $res['points'] = $this->points;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['consumeDetail'])) {
            $model->consumeDetail = consumeDetail::fromMap($map['consumeDetail']);
        }
        if (isset($map['pointPoolCode'])) {
            $model->pointPoolCode = $map['pointPoolCode'];
        }
        if (isset($map['points'])) {
            $model->points = $map['points'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
