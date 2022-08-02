<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeQueryStudentInfoByMobileRequest extends Model
{
    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobile;
    protected $_name = [
        'mobile' => 'mobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeQueryStudentInfoByMobileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }

        return $model;
    }
}
