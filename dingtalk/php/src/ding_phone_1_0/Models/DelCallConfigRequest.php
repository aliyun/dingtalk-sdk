<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models;

use AlibabaCloud\Tea\Model;

class DelCallConfigRequest extends Model
{
    /**
     * @example ding3f583b067250d34dd
     *
     * @var string
     */
    public $corpId;

    /**
     * @example token1233143
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
    protected $_name = [
        'corpId'      => 'corpId',
        'isvToken'    => 'isvToken',
        'phoneNumber' => 'phoneNumber',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DelCallConfigRequest
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

        return $model;
    }
}
