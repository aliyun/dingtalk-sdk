<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllSubjectsFromClassScheduleShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $classIdsShrink;

    /**
     * @description This parameter is required.
     *
     * @example 34524523543
     *
     * @var string
     */
    public $opUserId;

    /**
     * @example KINDERGARTEN
     *
     * @var string
     */
    public $periodCode;
    protected $_name = [
        'classIdsShrink' => 'classIds',
        'opUserId' => 'opUserId',
        'periodCode' => 'periodCode',
    ];

    public function validate() {}

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
