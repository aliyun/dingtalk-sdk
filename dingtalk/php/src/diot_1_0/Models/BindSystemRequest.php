<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BindSystemRequest extends Model
{
    /**
     * @description 与三方平台绑定验证的临时授权码。
     *
     * @var string
     */
    public $authCode;

    /**
     * @description 三方平台的用户ID。
     *
     * @var string
     */
    public $clientId;

    /**
     * @description 三方平台的用户名。
     *
     * @var string
     */
    public $clientName;

    /**
     * @description 三方平台的用户的钉钉物联组织ID。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 三方平台协定的其它参数。
     *
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
