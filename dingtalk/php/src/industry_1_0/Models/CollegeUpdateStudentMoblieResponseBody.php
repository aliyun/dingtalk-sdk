<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeUpdateStudentMoblieResponseBody extends Model
{
    /**
     * @description 修改结果
     *
     * @var string
     */
    public $updateResult;
    protected $_name = [
        'updateResult' => 'updateResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->updateResult) {
            $res['updateResult'] = $this->updateResult;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeUpdateStudentMoblieResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['updateResult'])) {
            $model->updateResult = $map['updateResult'];
        }

        return $model;
    }
}
