<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGoodsListRequest extends Model
{
    /**
     * @example 1631289600000
     *
     * @var int
     */
    public $endTimeInMills;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 1
     *
     * @var int
     */
    public $nextToken;

    /**
     * @example 1631289600000
     *
     * @var int
     */
    public $startTimeInMills;
    protected $_name = [
        'endTimeInMills'   => 'endTimeInMills',
        'maxResults'       => 'maxResults',
        'nextToken'        => 'nextToken',
        'startTimeInMills' => 'startTimeInMills',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTimeInMills) {
            $res['endTimeInMills'] = $this->endTimeInMills;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->startTimeInMills) {
            $res['startTimeInMills'] = $this->startTimeInMills;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGoodsListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTimeInMills'])) {
            $model->endTimeInMills = $map['endTimeInMills'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['startTimeInMills'])) {
            $model->startTimeInMills = $map['startTimeInMills'];
        }

        return $model;
    }
}
