<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendServiceGroupMessageResponseBody extends Model
{
    /**
     * @description 开放消息任务ID
     *
     * @var string
     */
    public $openMsgTaskId;
    protected $_name = [
        'openMsgTaskId' => 'openMsgTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openMsgTaskId) {
            $res['openMsgTaskId'] = $this->openMsgTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendServiceGroupMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openMsgTaskId'])) {
            $model->openMsgTaskId = $map['openMsgTaskId'];
        }

        return $model;
    }
}
