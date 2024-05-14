<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeletePhysicalClassroomRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 100016
     *
     * @var int
     */
    public $classroomId;

    /**
     * @description This parameter is required.
     *
     * @example manger234
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'classroomId' => 'classroomId',
        'opUserId'    => 'opUserId',
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
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeletePhysicalClassroomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classroomId'])) {
            $model->classroomId = $map['classroomId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
