<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvokeInstanceResponseBody extends Model
{
    /**
     * @description 本次执行耗时
     *
     * @var int
     */
    public $cost;

    /**
     * @description 连接器错误码
     *
     * @var string
     */
    public $errorCode;

    /**
     * @description 连接器错误信息
     *
     * @var string
     */
    public $errorMessage;

    /**
     * @description 调用记录的ID
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description Id of the request
     *
     * @var string
     */
    public $outputJson;
    protected $_name = [
        'cost'         => 'cost',
        'errorCode'    => 'errorCode',
        'errorMessage' => 'errorMessage',
        'instanceId'   => 'instanceId',
        'outputJson'   => 'outputJson',
    ];

    public function validate()
    {
    }

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
