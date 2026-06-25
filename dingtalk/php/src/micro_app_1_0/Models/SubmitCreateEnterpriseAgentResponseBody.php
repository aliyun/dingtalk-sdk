<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitCreateEnterpriseAgentResponseBody extends Model
{
    /**
     * @var string
     */
    public $expiresIn;

    /**
     * @var string
     */
    public $interval;

    /**
     * @var string
     */
    public $retryCount;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'expiresIn' => 'expiresIn',
        'interval' => 'interval',
        'retryCount' => 'retryCount',
        'status' => 'status',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expiresIn) {
            $res['expiresIn'] = $this->expiresIn;
        }
        if (null !== $this->interval) {
            $res['interval'] = $this->interval;
        }
        if (null !== $this->retryCount) {
            $res['retryCount'] = $this->retryCount;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitCreateEnterpriseAgentResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expiresIn'])) {
            $model->expiresIn = $map['expiresIn'];
        }
        if (isset($map['interval'])) {
            $model->interval = $map['interval'];
        }
        if (isset($map['retryCount'])) {
            $model->retryCount = $map['retryCount'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
