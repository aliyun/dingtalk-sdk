<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListEmpLeaveRecordsRequest extends Model
{
    /**
     * @description 结束时间，YYYY-MM-DDTHH:mm:ssZ (ISO 8601/RFC 3339)
     *
     * @var string
     */
    public $endTime;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 开始时间，YYYY-MM-DDTHH:mm:ssZ (ISO 8601/RFC 3339)
     *
     * @var string
     */
    public $startTime;
    protected $_name = [
        'endTime'    => 'endTime',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'startTime'  => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListEmpLeaveRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
