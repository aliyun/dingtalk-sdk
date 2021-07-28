<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySubjectTeachersRequest extends Model
{
    /**
     * @description 班级ids
     *
     * @var int[]
     */
    public $classIds;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 学科code
     *
     * @var string
     */
    public $subjectCode;
    protected $_name = [
        'classIds'    => 'classIds',
        'opUserId'    => 'opUserId',
        'subjectCode' => 'subjectCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classIds) {
            $res['classIds'] = $this->classIds;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySubjectTeachersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classIds'])) {
            if (!empty($map['classIds'])) {
                $model->classIds = $map['classIds'];
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }

        return $model;
    }
}
