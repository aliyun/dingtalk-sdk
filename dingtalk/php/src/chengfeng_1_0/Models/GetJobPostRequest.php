<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetJobPostRequest extends Model
{
    /**
     * @description 职务编码
     *
     * @var string
     */
    public $jobPostCode;
    protected $_name = [
        'jobPostCode' => 'jobPostCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobPostCode) {
            $res['jobPostCode'] = $this->jobPostCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetJobPostRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobPostCode'])) {
            $model->jobPostCode = $map['jobPostCode'];
        }

        return $model;
    }
}
