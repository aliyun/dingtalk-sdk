<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeUpdateStudentMoblieRequest extends Model
{
    /**
     * @description 是否直接更换
     *
     * @var bool
     */
    public $isForce;

    /**
     * @description 修改后的手机号
     *
     * @var string
     */
    public $newMobile;

    /**
     * @description 学生id
     *
     * @var int
     */
    public $studentId;
    protected $_name = [
        'isForce'   => 'isForce',
        'newMobile' => 'newMobile',
        'studentId' => 'studentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isForce) {
            $res['isForce'] = $this->isForce;
        }
        if (null !== $this->newMobile) {
            $res['newMobile'] = $this->newMobile;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeUpdateStudentMoblieRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isForce'])) {
            $model->isForce = $map['isForce'];
        }
        if (isset($map['newMobile'])) {
            $model->newMobile = $map['newMobile'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }

        return $model;
    }
}
