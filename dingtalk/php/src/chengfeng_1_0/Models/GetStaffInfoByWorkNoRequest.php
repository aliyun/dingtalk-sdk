<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetStaffInfoByWorkNoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $workNumbers;
    protected $_name = [
        'workNumbers' => 'workNumbers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->workNumbers) {
            $res['workNumbers'] = $this->workNumbers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetStaffInfoByWorkNoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workNumbers'])) {
            $model->workNumbers = $map['workNumbers'];
        }

        return $model;
    }
}
