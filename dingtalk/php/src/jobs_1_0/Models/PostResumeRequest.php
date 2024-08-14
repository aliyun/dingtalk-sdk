<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models;

use AlibabaCloud\Tea\Model;

class PostResumeRequest extends Model
{
    /**
     * @var int
     */
    public $jobId;

    /**
     * @var string
     */
    public $userIdentify;
    protected $_name = [
        'jobId'        => 'jobId',
        'userIdentify' => 'userIdentify',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->userIdentify) {
            $res['userIdentify'] = $this->userIdentify;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PostResumeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['userIdentify'])) {
            $model->userIdentify = $map['userIdentify'];
        }

        return $model;
    }
}
