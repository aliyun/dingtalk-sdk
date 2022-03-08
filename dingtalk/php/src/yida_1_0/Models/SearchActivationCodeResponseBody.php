<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchActivationCodeResponseBody extends Model
{
    /**
     * @description activationCode
     *
     * @var string
     */
    public $activationCode;

    /**
     * @description authType
     *
     * @var string
     */
    public $authType;

    /**
     * @description expireTime
     *
     * @var string
     */
    public $expireTimeGMT;

    /**
     * @description instanceId
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description status
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'activationCode' => 'activationCode',
        'authType'       => 'authType',
        'expireTimeGMT'  => 'expireTimeGMT',
        'instanceId'     => 'instanceId',
        'status'         => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activationCode) {
            $res['activationCode'] = $this->activationCode;
        }
        if (null !== $this->authType) {
            $res['authType'] = $this->authType;
        }
        if (null !== $this->expireTimeGMT) {
            $res['expireTimeGMT'] = $this->expireTimeGMT;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchActivationCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activationCode'])) {
            $model->activationCode = $map['activationCode'];
        }
        if (isset($map['authType'])) {
            $model->authType = $map['authType'];
        }
        if (isset($map['expireTimeGMT'])) {
            $model->expireTimeGMT = $map['expireTimeGMT'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
