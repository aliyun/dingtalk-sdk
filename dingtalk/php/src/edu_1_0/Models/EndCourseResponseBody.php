<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseResponseBody\universityCourseCommonResponse;
use AlibabaCloud\Tea\Model;

class EndCourseResponseBody extends Model
{
    /**
     * @var universityCourseCommonResponse
     */
    public $universityCourseCommonResponse;
    protected $_name = [
        'universityCourseCommonResponse' => 'universityCourseCommonResponse',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->universityCourseCommonResponse) {
            $res['universityCourseCommonResponse'] = null !== $this->universityCourseCommonResponse ? $this->universityCourseCommonResponse->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EndCourseResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['universityCourseCommonResponse'])) {
            $model->universityCourseCommonResponse = universityCourseCommonResponse::fromMap($map['universityCourseCommonResponse']);
        }

        return $model;
    }
}
