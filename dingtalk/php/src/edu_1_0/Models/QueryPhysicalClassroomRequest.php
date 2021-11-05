<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPhysicalClassroomRequest extends Model
{
    /**
     * @description 操作人id
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 教室id
     *
     * @var int
     */
    public $classroomId;
    protected $_name = [
        'opUserId'    => 'opUserId',
        'classroomId' => 'classroomId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->classroomId) {
            $res['classroomId'] = $this->classroomId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPhysicalClassroomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['classroomId'])) {
            $model->classroomId = $map['classroomId'];
        }

        return $model;
    }
}
