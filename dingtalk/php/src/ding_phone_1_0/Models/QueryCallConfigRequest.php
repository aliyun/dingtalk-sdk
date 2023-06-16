<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCallConfigRequest extends Model
{
    /**
     * @example ding3f583b0672efc12d
     *
     * @var string
     */
    public $corpId;

    /**
     * @example token23dafds
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
     * @return QueryCallConfigRequest
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
