<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data;

use AlibabaCloud\Tea\Model;

class riskCounts extends Model
{
    /**
     * @var int
     */
    public $high;

    /**
     * @var int
     */
    public $low;

    /**
     * @var int
     */
    public $medium;
    protected $_name = [
        'high' => 'high',
        'low' => 'low',
        'medium' => 'medium',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->high) {
            $res['high'] = $this->high;
        }
        if (null !== $this->low) {
            $res['low'] = $this->low;
        }
        if (null !== $this->medium) {
            $res['medium'] = $this->medium;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return riskCounts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['high'])) {
            $model->high = $map['high'];
        }
        if (isset($map['low'])) {
            $model->low = $map['low'];
        }
        if (isset($map['medium'])) {
            $model->medium = $map['medium'];
        }

        return $model;
    }
}
