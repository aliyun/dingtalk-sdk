<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInterviewSignInInfoRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example 1626796800000
     *
     * @var int
     */
    public $signInTimeMillis;
    protected $_name = [
        'bizCode'          => 'bizCode',
        'signInTimeMillis' => 'signInTimeMillis',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->signInTimeMillis) {
            $res['signInTimeMillis'] = $this->signInTimeMillis;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInterviewSignInInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['signInTimeMillis'])) {
            $model->signInTimeMillis = $map['signInTimeMillis'];
        }

        return $model;
    }
}
