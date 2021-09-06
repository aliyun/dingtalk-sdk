<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotDingMessageResponseBody extends Model
{
    /**
     * @description 返回的ding消息id
     *
     * @var string
     */
    public $dingSendResultId;
    protected $_name = [
        'dingSendResultId' => 'dingSendResultId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingSendResultId) {
            $res['dingSendResultId'] = $this->dingSendResultId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRobotDingMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingSendResultId'])) {
            $model->dingSendResultId = $map['dingSendResultId'];
        }

        return $model;
    }
}
