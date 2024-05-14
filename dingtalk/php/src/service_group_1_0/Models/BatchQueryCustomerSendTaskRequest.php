<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryCustomerSendTaskRequest extends Model
{
    /**
     * @example 2023-06-02 00:00:00
     *
     * @var string
     */
    public $gmtCreateEnd;

    /**
     * @example 2023-06-01 00:00:00
     *
     * @var string
     */
    public $gmtCreateStart;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $needRichStatistics;

    /**
     * @example 1
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var string[]
     */
    public $openBatchTaskIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 哈哈哈
     *
     * @var string
     */
    public $taskName;
    protected $_name = [
        'gmtCreateEnd'       => 'gmtCreateEnd',
        'gmtCreateStart'     => 'gmtCreateStart',
        'maxResults'         => 'maxResults',
        'needRichStatistics' => 'needRichStatistics',
        'nextToken'          => 'nextToken',
        'openBatchTaskIds'   => 'openBatchTaskIds',
        'openTeamId'         => 'openTeamId',
        'taskName'           => 'taskName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreateEnd) {
            $res['gmtCreateEnd'] = $this->gmtCreateEnd;
        }
        if (null !== $this->gmtCreateStart) {
            $res['gmtCreateStart'] = $this->gmtCreateStart;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->needRichStatistics) {
            $res['needRichStatistics'] = $this->needRichStatistics;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openBatchTaskIds) {
            $res['openBatchTaskIds'] = $this->openBatchTaskIds;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryCustomerSendTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreateEnd'])) {
            $model->gmtCreateEnd = $map['gmtCreateEnd'];
        }
        if (isset($map['gmtCreateStart'])) {
            $model->gmtCreateStart = $map['gmtCreateStart'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['needRichStatistics'])) {
            $model->needRichStatistics = $map['needRichStatistics'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openBatchTaskIds'])) {
            if (!empty($map['openBatchTaskIds'])) {
                $model->openBatchTaskIds = $map['openBatchTaskIds'];
            }
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }

        return $model;
    }
}
