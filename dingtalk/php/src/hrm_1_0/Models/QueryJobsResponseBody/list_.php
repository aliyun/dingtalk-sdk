<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 职务描述
     *
     * @var string
     */
    public $jobDescription;

    /**
     * @example ac67286db74c48e28d787173ccc1a111
     *
     * @var string
     */
    public $jobId;

    /**
     * @example 总裁
     *
     * @var string
     */
    public $jobName;
    protected $_name = [
        'jobDescription' => 'jobDescription',
        'jobId'          => 'jobId',
        'jobName'        => 'jobName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobDescription) {
            $res['jobDescription'] = $this->jobDescription;
        }
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->jobName) {
            $res['jobName'] = $this->jobName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobDescription'])) {
            $model->jobDescription = $map['jobDescription'];
        }
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['jobName'])) {
            $model->jobName = $map['jobName'];
        }

        return $model;
    }
}
