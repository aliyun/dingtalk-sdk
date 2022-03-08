<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptsByPageRequest extends Model
{
    /**
     * @description 检索结束时间，默认当前时间，离开始时间最长不超过180天
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 数据模型id
     *
     * @var string
     */
    public $modelId;

    /**
     * @description 分页，从1开始
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小，默认10，最大100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 检索开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 检索排序时间类型：创建时间(gmt_create)，更新时间(gmt_modified)
     *
     * @var string
     */
    public $timeFilterField;
    protected $_name = [
        'endTime'         => 'endTime',
        'modelId'         => 'modelId',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'startTime'       => 'startTime',
        'timeFilterField' => 'timeFilterField',
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
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->timeFilterField) {
            $res['timeFilterField'] = $this->timeFilterField;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryReceiptsByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['timeFilterField'])) {
            $model->timeFilterField = $map['timeFilterField'];
        }

        return $model;
    }
}
