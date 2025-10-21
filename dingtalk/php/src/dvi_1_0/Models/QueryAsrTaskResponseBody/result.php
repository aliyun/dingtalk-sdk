<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAsrTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAsrTaskResponseBody\result\resultInfo;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $bizKey;

    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMessage;

    /**
     * @var resultInfo
     */
    public $resultInfo;

    /**
     * @var string
     */
    public $taskId;

    /**
     * @var string
     */
    public $taskStatus;
    protected $_name = [
        'bizKey' => 'bizKey',
        'errorCode' => 'errorCode',
        'errorMessage' => 'errorMessage',
        'resultInfo' => 'resultInfo',
        'taskId' => 'taskId',
        'taskStatus' => 'taskStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizKey) {
            $res['bizKey'] = $this->bizKey;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMessage) {
            $res['errorMessage'] = $this->errorMessage;
        }
        if (null !== $this->resultInfo) {
            $res['resultInfo'] = null !== $this->resultInfo ? $this->resultInfo->toMap() : null;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizKey'])) {
            $model->bizKey = $map['bizKey'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMessage'])) {
            $model->errorMessage = $map['errorMessage'];
        }
        if (isset($map['resultInfo'])) {
            $model->resultInfo = resultInfo::fromMap($map['resultInfo']);
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }

        return $model;
    }
}
