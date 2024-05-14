<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptsByPageRequest extends Model
{
    /**
     * @example 1637658261363
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example EM-1017F28E03350B1738B3000X
     *
     * @var string
     */
    public $modelId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example 1637658261363
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example gmt_create
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
