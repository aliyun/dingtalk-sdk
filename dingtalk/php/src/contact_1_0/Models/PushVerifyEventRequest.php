<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushVerifyEventRequest extends Model
{
    /**
     * @var string
     */
    public $callerDeviceId;

    /**
     * @var string[]
     */
    public $factorCodeList;

    /**
     * @var string
     */
    public $state;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'callerDeviceId' => 'callerDeviceId',
        'factorCodeList' => 'factorCodeList',
        'state'          => 'state',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callerDeviceId) {
            $res['callerDeviceId'] = $this->callerDeviceId;
        }
        if (null !== $this->factorCodeList) {
            $res['factorCodeList'] = $this->factorCodeList;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushVerifyEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callerDeviceId'])) {
            $model->callerDeviceId = $map['callerDeviceId'];
        }
        if (isset($map['factorCodeList'])) {
            if (!empty($map['factorCodeList'])) {
                $model->factorCodeList = $map['factorCodeList'];
            }
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
