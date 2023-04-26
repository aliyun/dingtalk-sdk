<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBatchSendResultRequest extends Model
{
    /**
     * @example 234#dingxxx@dingding
     *
     * @var string
     */
    public $senderUserId;

    /**
     * @example 1234567890
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'senderUserId' => 'senderUserId',
        'taskId'       => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBatchSendResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
