<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUniversityCourseGroupRequest extends Model
{
    /**
     * @description 操作人
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 课程编码
     *
     * @var string
     */
    public $courseGroupCode;
    protected $_name = [
        'opUserId'        => 'opUserId',
        'courseGroupCode' => 'courseGroupCode',
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
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUniversityCourseGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }

        return $model;
    }
}
