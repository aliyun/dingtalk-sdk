<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetActiveUserSummaryResponseBody extends Model
{
    /**
     * @description 月活跃人数
     *
     * @var string
     */
    public $actUsrCnt1m;
    protected $_name = [
        'actUsrCnt1m' => 'actUsrCnt1m',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actUsrCnt1m) {
            $res['actUsrCnt1m'] = $this->actUsrCnt1m;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetActiveUserSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actUsrCnt1m'])) {
            $model->actUsrCnt1m = $map['actUsrCnt1m'];
        }

        return $model;
    }
}
