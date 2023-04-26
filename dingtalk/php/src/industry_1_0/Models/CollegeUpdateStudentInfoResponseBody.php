<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeUpdateStudentInfoResponseBody extends Model
{
    /**
     * @example true
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
     * @return CollegeUpdateStudentInfoResponseBody
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
