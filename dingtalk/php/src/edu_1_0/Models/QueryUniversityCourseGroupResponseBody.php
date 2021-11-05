<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupResponseBody\universityCourseGroupInfo;
use AlibabaCloud\Tea\Model;

class QueryUniversityCourseGroupResponseBody extends Model
{
    /**
     * @description 课程组信息
     *
     * @var universityCourseGroupInfo
     */
    public $universityCourseGroupInfo;
    protected $_name = [
        'universityCourseGroupInfo' => 'universityCourseGroupInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->universityCourseGroupInfo) {
            $res['universityCourseGroupInfo'] = null !== $this->universityCourseGroupInfo ? $this->universityCourseGroupInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUniversityCourseGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['universityCourseGroupInfo'])) {
            $model->universityCourseGroupInfo = universityCourseGroupInfo::fromMap($map['universityCourseGroupInfo']);
        }

        return $model;
    }
}
