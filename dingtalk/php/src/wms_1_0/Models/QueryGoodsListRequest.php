<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGoodsListRequest extends Model
{
    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTimeInMills;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页起始值
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 开始时间
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
