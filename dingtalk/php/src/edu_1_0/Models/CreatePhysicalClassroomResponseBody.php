<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreatePhysicalClassroomResponseBody extends Model
{
    /**
     * @description 教室id
     *
     * @var int
     */
    public $classroomId;
    protected $_name = [
        'classroomId' => 'classroomId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classroomId) {
            $res['classroomId'] = $this->classroomId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePhysicalClassroomResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classroomId'])) {
            $model->classroomId = $map['classroomId'];
        }

        return $model;
    }
}
