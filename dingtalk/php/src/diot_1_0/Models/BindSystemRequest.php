<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BindSystemRequest extends Model
{
    /**
     * @example abcde12345
     *
     * @var string
     */
    public $authCode;

    /**
     * @description This parameter is required.
     *
     * @example d12345
     *
     * @var string
     */
    public $clientId;

    /**
     * @description This parameter is required.
     *
     * @example xx社区。
     *
     * @var string
     */
    public $clientName;

    /**
     * @description This parameter is required.
     *
     * @example ding12345
     *
     * @var string
     */
    public $corpId;

    /**
     * @var mixed[]
     */
    public $extraData;
    protected $_name = [
        'authCode'   => 'authCode',
        'clientId'   => 'clientId',
        'clientName' => 'clientName',
        'corpId'     => 'corpId',
        'extraData'  => 'extraData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
        }
        if (null !== $this->clientName) {
            $res['clientName'] = $this->clientName;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extraData) {
            $res['extraData'] = $this->extraData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BindSystemRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }
        if (isset($map['clientName'])) {
            $model->clientName = $map['clientName'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extraData'])) {
            $model->extraData = $map['extraData'];
        }

        return $model;
    }
}
