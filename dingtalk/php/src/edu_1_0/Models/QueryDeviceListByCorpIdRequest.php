<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDeviceListByCorpIdRequest extends Model
{
    /**
     * @var string
     */
    public $operator;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'operator'   => 'operator',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDeviceListByCorpIdRequest
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

        return $model;
    }
}
