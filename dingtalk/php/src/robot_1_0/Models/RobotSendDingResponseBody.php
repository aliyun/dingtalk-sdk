<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotSendDingResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $failedList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $openDingId;
    protected $_name = [
        'failedList' => 'failedList',
        'openDingId' => 'openDingId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failedList) {
            $res['failedList'] = $this->failedList;
        }
        if (null !== $this->openDingId) {
            $res['openDingId'] = $this->openDingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotSendDingResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failedList'])) {
            $model->failedList = $map['failedList'];
        }
        if (isset($map['openDingId'])) {
            $model->openDingId = $map['openDingId'];
        }

        return $model;
    }
}
