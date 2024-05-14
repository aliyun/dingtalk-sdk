<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteUniversityStudentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 76781
     *
     * @var int
     */
    public $classId;

    /**
     * @description This parameter is required.
     *
     * @example manger1234
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example uu1234
     *
     * @var string
     */
    public $studentUserId;
    protected $_name = [
        'classId'       => 'classId',
        'opUserId'      => 'opUserId',
        'studentUserId' => 'studentUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteUniversityStudentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }

        return $model;
    }
}
