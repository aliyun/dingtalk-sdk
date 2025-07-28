<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvokeInstanceResponseBody extends Model
{
    /**
     * @example 13
     *
     * @var int
     */
    public $cost;

    /**
     * @example 0
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example success
     *
     * @var string
     */
    public $errorMessage;

    /**
     * @example 43b28ecffae-f-t_
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example {}
     *
     * @var string
     */
    public $outputJson;
    protected $_name = [
        'cost' => 'cost',
        'errorCode' => 'errorCode',
        'errorMessage' => 'errorMessage',
        'instanceId' => 'instanceId',
        'outputJson' => 'outputJson',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cost) {
            $res['cost'] = $this->cost;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMessage) {
            $res['errorMessage'] = $this->errorMessage;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->outputJson) {
            $res['outputJson'] = $this->outputJson;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvokeInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cost'])) {
            $model->cost = $map['cost'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMessage'])) {
            $model->errorMessage = $map['errorMessage'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['outputJson'])) {
            $model->outputJson = $map['outputJson'];
        }

        return $model;
    }
}
