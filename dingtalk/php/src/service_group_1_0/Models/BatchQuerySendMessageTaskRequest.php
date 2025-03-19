<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQuerySendMessageTaskRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $getReadCount;

    /**
     * @example 2022-04-02 00:00:00
     *
     * @var string
     */
    public $gmtCreateEnd;

    /**
     * @example 2022-04-01 00:00:00
     *
     * @var string
     */
    public $gmtCreateStart;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 首页传递空
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example fwPuycdHiiI
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description This parameter is required.
     *
     * @example Jciwnfw
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 群发任务双11
     *
     * @var string
     */
    public $taskName;
    protected $_name = [
        'getReadCount' => 'getReadCount',
        'gmtCreateEnd' => 'gmtCreateEnd',
        'gmtCreateStart' => 'gmtCreateStart',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'openGroupSetId' => 'openGroupSetId',
        'openTeamId' => 'openTeamId',
        'taskName' => 'taskName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->getReadCount) {
            $res['getReadCount'] = $this->getReadCount;
        }
        if (null !== $this->gmtCreateEnd) {
            $res['gmtCreateEnd'] = $this->gmtCreateEnd;
        }
        if (null !== $this->gmtCreateStart) {
            $res['gmtCreateStart'] = $this->gmtCreateStart;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
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
     * @return BatchQuerySendMessageTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['getReadCount'])) {
            $model->getReadCount = $map['getReadCount'];
        }
        if (isset($map['gmtCreateEnd'])) {
            $model->gmtCreateEnd = $map['gmtCreateEnd'];
        }
        if (isset($map['gmtCreateStart'])) {
            $model->gmtCreateStart = $map['gmtCreateStart'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
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
