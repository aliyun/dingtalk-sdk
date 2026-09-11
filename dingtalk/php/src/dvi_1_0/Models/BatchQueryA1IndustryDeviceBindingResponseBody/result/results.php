<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryA1IndustryDeviceBindingResponseBody\result;

use AlibabaCloud\Tea\Model;

class results extends Model
{
    /**
     * @var int
     */
    public $bindTimestamp;

    /**
     * @var string
     */
    public $bindingStatus;

    /**
     * @var int
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMessage;

    /**
     * @var string
     */
    public $sn;

    /**
     * @var bool
     */
    public $success;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bindTimestamp' => 'bindTimestamp',
        'bindingStatus' => 'bindingStatus',
        'errorCode' => 'errorCode',
        'errorMessage' => 'errorMessage',
        'sn' => 'sn',
        'success' => 'success',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindTimestamp) {
            $res['bindTimestamp'] = $this->bindTimestamp;
        }
        if (null !== $this->bindingStatus) {
            $res['bindingStatus'] = $this->bindingStatus;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMessage) {
            $res['errorMessage'] = $this->errorMessage;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return results
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindTimestamp'])) {
            $model->bindTimestamp = $map['bindTimestamp'];
        }
        if (isset($map['bindingStatus'])) {
            $model->bindingStatus = $map['bindingStatus'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMessage'])) {
            $model->errorMessage = $map['errorMessage'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
