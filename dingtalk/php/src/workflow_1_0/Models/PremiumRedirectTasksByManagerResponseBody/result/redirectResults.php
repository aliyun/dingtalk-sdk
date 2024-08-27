<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumRedirectTasksByManagerResponseBody\result;

use AlibabaCloud\Tea\Model;

class redirectResults extends Model
{
    /**
     * @example 外部流程不允许转交
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @description This parameter is required.
     *
     * @example success
     *
     * @var bool
     */
    public $success;

    /**
     * @description This parameter is required.
     *
     * @example 1234567
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'errorMsg' => 'errorMsg',
        'success'  => 'success',
        'taskId'   => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return redirectResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
