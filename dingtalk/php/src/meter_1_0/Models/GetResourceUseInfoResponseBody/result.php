<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmeter_1_0\Models\GetResourceUseInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $quotaNum;

    /**
     * @var int
     */
    public $usedNum;
    protected $_name = [
        'quotaNum' => 'quotaNum',
        'usedNum' => 'usedNum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->quotaNum) {
            $res['quotaNum'] = $this->quotaNum;
        }
        if (null !== $this->usedNum) {
            $res['usedNum'] = $this->usedNum;
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
        if (isset($map['quotaNum'])) {
            $model->quotaNum = $map['quotaNum'];
        }
        if (isset($map['usedNum'])) {
            $model->usedNum = $map['usedNum'];
        }

        return $model;
    }
}
