<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryJobsRequest extends Model
{
    /**
     * @description 职务名称
     *
     * @var string
     */
    public $jobName;

    /**
     * @description 偏移量
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 最大值
     *
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'jobName'    => 'jobName',
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobName) {
            $res['jobName'] = $this->jobName;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryJobsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobName'])) {
            $model->jobName = $map['jobName'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }

        return $model;
    }
}
