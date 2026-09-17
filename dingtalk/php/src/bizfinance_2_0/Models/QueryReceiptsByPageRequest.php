<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptsByPageRequest extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string[]
     */
    public $modelIds;

    /**
     * @var int
     */
    public $pageIndex;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $timeFilterField;
    protected $_name = [
        'endTime' => 'endTime',
        'modelIds' => 'modelIds',
        'pageIndex' => 'pageIndex',
        'pageSize' => 'pageSize',
        'startTime' => 'startTime',
        'timeFilterField' => 'timeFilterField',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->modelIds) {
            $res['modelIds'] = $this->modelIds;
        }
        if (null !== $this->pageIndex) {
            $res['pageIndex'] = $this->pageIndex;
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
        if (isset($map['modelIds'])) {
            if (!empty($map['modelIds'])) {
                $model->modelIds = $map['modelIds'];
            }
        }
        if (isset($map['pageIndex'])) {
            $model->pageIndex = $map['pageIndex'];
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
