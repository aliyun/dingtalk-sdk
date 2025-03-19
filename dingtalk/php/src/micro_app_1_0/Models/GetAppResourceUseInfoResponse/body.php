<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetAppResourceUseInfoResponse;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @example 202301
     *
     * @var string
     */
    public $period;

    /**
     * @example 8511
     *
     * @var int
     */
    public $usedNum;

    /**
     * @example 10000
     *
     * @var int
     */
    public $quotaNum;
    protected $_name = [
        'period' => 'period',
        'usedNum' => 'usedNum',
        'quotaNum' => 'quotaNum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->usedNum) {
            $res['usedNum'] = $this->usedNum;
        }
        if (null !== $this->quotaNum) {
            $res['quotaNum'] = $this->quotaNum;
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
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['usedNum'])) {
            $model->usedNum = $map['usedNum'];
        }
        if (isset($map['quotaNum'])) {
            $model->quotaNum = $map['quotaNum'];
        }

        return $model;
    }
}
