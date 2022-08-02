<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeUpdateCollegeDeptResponseBody extends Model
{
    /**
     * @description 更新部门信息是否成功
     *
     * @var bool
     */
    public $isSuccessful;
    protected $_name = [
        'isSuccessful' => 'isSuccessful',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isSuccessful) {
            $res['isSuccessful'] = $this->isSuccessful;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeUpdateCollegeDeptResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isSuccessful'])) {
            $model->isSuccessful = $map['isSuccessful'];
        }

        return $model;
    }
}
