<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvalidStudentClassRequest extends Model
{
    /**
     * @example classxxx
     *
     * @var string
     */
    public $classId;

    /**
     * @example 1
     *
     * @var int
     */
    public $classType;

    /**
     * @example dingxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @var string[]
     */
    public $studentUserIds;
    protected $_name = [
        'classId'        => 'classId',
        'classType'      => 'classType',
        'corpId'         => 'corpId',
        'isvCode'        => 'isvCode',
        'studentUserIds' => 'studentUserIds',
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
        if (null !== $this->classType) {
            $res['classType'] = $this->classType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->studentUserIds) {
            $res['studentUserIds'] = $this->studentUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvalidStudentClassRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['classType'])) {
            $model->classType = $map['classType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['studentUserIds'])) {
            if (!empty($map['studentUserIds'])) {
                $model->studentUserIds = $map['studentUserIds'];
            }
        }

        return $model;
    }
}
