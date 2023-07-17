<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotRecallDingResponseBody extends Model
{
    /**
     * @var string
     */
    public $openDingId;
    protected $_name = [
        'openDingId' => 'openDingId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openDingId) {
            $res['openDingId'] = $this->openDingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotRecallDingResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openDingId'])) {
            $model->openDingId = $map['openDingId'];
        }

        return $model;
    }
}
