<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCandidateByPhoneNumberRequest extends Model
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
     * @example 13688888888
     *
     * @var string
     */
    public $phoneNumber;
    protected $_name = [
        'bizCode'     => 'bizCode',
        'phoneNumber' => 'phoneNumber',
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
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCandidateByPhoneNumberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }

        return $model;
    }
}
