<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTaskListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example staff234
     *
     * @var string
     */
    public $operator;

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
     * @example 2023
     *
     * @var int
     */
    public $taskYear;
    protected $_name = [
        'operator'   => 'operator',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'taskYear'   => 'taskYear',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->taskYear) {
            $res['taskYear'] = $this->taskYear;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTaskListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['taskYear'])) {
            $model->taskYear = $map['taskYear'];
        }

        return $model;
    }
}
