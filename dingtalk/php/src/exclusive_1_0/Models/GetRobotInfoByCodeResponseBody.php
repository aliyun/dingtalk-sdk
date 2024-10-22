<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRobotInfoByCodeResponseBody\robotInfoVO;
use AlibabaCloud\Tea\Model;

class GetRobotInfoByCodeResponseBody extends Model
{
    /**
     * @var robotInfoVO
     */
    public $robotInfoVO;
    protected $_name = [
        'robotInfoVO' => 'robotInfoVO',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotInfoVO) {
            $res['robotInfoVO'] = null !== $this->robotInfoVO ? $this->robotInfoVO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRobotInfoByCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotInfoVO'])) {
            $model->robotInfoVO = robotInfoVO::fromMap($map['robotInfoVO']);
        }

        return $model;
    }
}
