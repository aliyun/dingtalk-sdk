<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryStaffStatisticDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $day;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $teamCode;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'day' => 'day',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'teamCode' => 'teamCode',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->day) {
            $res['day'] = $this->day;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryStaffStatisticDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['day'])) {
            $model->day = $map['day'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
