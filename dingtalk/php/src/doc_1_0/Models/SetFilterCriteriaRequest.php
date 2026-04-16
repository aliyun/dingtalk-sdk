<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetFilterCriteriaRequest\filterCriteria;
use AlibabaCloud\Tea\Model;

class SetFilterCriteriaRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $column;

    /**
     * @description This parameter is required.
     *
     * @var filterCriteria
     */
    public $filterCriteria;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'column' => 'column',
        'filterCriteria' => 'filterCriteria',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->column) {
            $res['column'] = $this->column;
        }
        if (null !== $this->filterCriteria) {
            $res['filterCriteria'] = null !== $this->filterCriteria ? $this->filterCriteria->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetFilterCriteriaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['column'])) {
            $model->column = $map['column'];
        }
        if (isset($map['filterCriteria'])) {
            $model->filterCriteria = filterCriteria::fromMap($map['filterCriteria']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
