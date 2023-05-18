<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections\punches;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections\punches\lateBackSetting\lateBackPairs;
use AlibabaCloud\Tea\Model;

class lateBackSetting extends Model
{
    /**
     * @var lateBackPairs[]
     */
    public $lateBackPairs;
    protected $_name = [
        'lateBackPairs' => 'lateBackPairs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lateBackPairs) {
            $res['lateBackPairs'] = [];
            if (null !== $this->lateBackPairs && \is_array($this->lateBackPairs)) {
                $n = 0;
                foreach ($this->lateBackPairs as $item) {
                    $res['lateBackPairs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return lateBackSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lateBackPairs'])) {
            if (!empty($map['lateBackPairs'])) {
                $model->lateBackPairs = [];
                $n                    = 0;
                foreach ($map['lateBackPairs'] as $item) {
                    $model->lateBackPairs[$n++] = null !== $item ? lateBackPairs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
