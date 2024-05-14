<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCallConfigRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding3f583b067f2q450c12d
     *
     * @var string
     */
    public $corpId;

    /**
     * @example token12345
     *
     * @var string
     */
    public $isvToken;

    /**
     * @example 057112345678
     *
     * @var string
     */
    public $phoneNumber;

    /**
     * @example call
     *
     * @var string
     */
    public $scopeType;
    protected $_name = [
        'corpId'      => 'corpId',
        'isvToken'    => 'isvToken',
        'phoneNumber' => 'phoneNumber',
        'scopeType'   => 'scopeType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvToken) {
            $res['isvToken'] = $this->isvToken;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCallConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvToken'])) {
            $model->isvToken = $map['isvToken'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }

        return $model;
    }
}
