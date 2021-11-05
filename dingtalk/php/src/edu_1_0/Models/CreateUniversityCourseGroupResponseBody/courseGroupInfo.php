<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupResponseBody;

use AlibabaCloud\Tea\Model;

class courseGroupInfo extends Model
{
    /**
     * @description 课程组编码
     *
     * @var string
     */
    public $courseGroupCode;
    protected $_name = [
        'courseGroupCode' => 'courseGroupCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return courseGroupInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }

        return $model;
    }
}
