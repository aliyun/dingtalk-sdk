<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupResponseBody\courseGroupInfo;
use AlibabaCloud\Tea\Model;

class CreateUniversityCourseGroupResponseBody extends Model
{
    /**
     * @description 课程组信息
     *
     * @var courseGroupInfo
     */
    public $courseGroupInfo;
    protected $_name = [
        'courseGroupInfo' => 'courseGroupInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseGroupInfo) {
            $res['courseGroupInfo'] = null !== $this->courseGroupInfo ? $this->courseGroupInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUniversityCourseGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseGroupInfo'])) {
            $model->courseGroupInfo = courseGroupInfo::fromMap($map['courseGroupInfo']);
        }

        return $model;
    }
}
