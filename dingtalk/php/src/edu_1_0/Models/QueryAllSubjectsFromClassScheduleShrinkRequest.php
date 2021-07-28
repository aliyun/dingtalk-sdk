<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllSubjectsFromClassScheduleShrinkRequest extends Model
{
    /**
     * @description 班级ID。
     *
     * @var string
     */
    public $classIdsShrink;

    /**
     * @description 操作者的userid。
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 学段编码：KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
     *
     * @var string
     */
    public $periodCode;
    protected $_name = [
        'classIdsShrink' => 'classIds',
        'opUserId'       => 'opUserId',
        'periodCode'     => 'periodCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classIdsShrink) {
            $res['classIds'] = $this->classIdsShrink;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllSubjectsFromClassScheduleShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classIds'])) {
            $model->classIdsShrink = $map['classIds'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }

        return $model;
    }
}
