<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCorpUserStatisticRequest extends Model
{
    /**
     * @description 结束时间（yyyymmdd）
     *
     * @var string
     */
    public $endTime;

    /**
     * @description 页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 当前页
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 开始时间（yyyymmdd）
     *
     * @var string
     */
    public $startTime;

    /**
     * @description 模版id列表
     *
     * @var string[]
     */
    public $templateIds;

    /**
     * @description 操作者id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'endTime'     => 'endTime',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'startTime'   => 'startTime',
        'templateIds' => 'templateIds',
        'unionId'     => 'unionId',
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
        if (null !== $this->templateIds) {
            $res['templateIds'] = $this->templateIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCorpUserStatisticRequest
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
        if (isset($map['templateIds'])) {
            if (!empty($map['templateIds'])) {
                $model->templateIds = $map['templateIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
