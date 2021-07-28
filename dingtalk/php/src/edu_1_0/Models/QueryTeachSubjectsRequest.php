<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTeachSubjectsRequest extends Model
{
    /**
     * @description 班级ids
     *
     * @var int[]
     */
    public $classIds;

    /**
     * @description 操作者UserId
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'classIds' => 'classIds',
        'opUserId' => 'opUserId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTeachSubjectsRequest
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

        return $model;
    }
}
