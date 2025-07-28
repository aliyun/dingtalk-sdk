<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\description;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\matrixData;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\matrixTable;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\name;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var description
     */
    public $description;

    /**
     * @var matrixData
     */
    public $matrixData;

    /**
     * @var string
     */
    public $matrixId;

    /**
     * @var matrixTable
     */
    public $matrixTable;

    /**
     * @var name
     */
    public $name;

    /**
     * @var int
     */
    public $rowTotalCount;
    protected $_name = [
        'description' => 'description',
        'matrixData' => 'matrixData',
        'matrixId' => 'matrixId',
        'matrixTable' => 'matrixTable',
        'name' => 'name',
        'rowTotalCount' => 'rowTotalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = null !== $this->description ? $this->description->toMap() : null;
        }
        if (null !== $this->matrixData) {
            $res['matrixData'] = null !== $this->matrixData ? $this->matrixData->toMap() : null;
        }
        if (null !== $this->matrixId) {
            $res['matrixId'] = $this->matrixId;
        }
        if (null !== $this->matrixTable) {
            $res['matrixTable'] = null !== $this->matrixTable ? $this->matrixTable->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->rowTotalCount) {
            $res['rowTotalCount'] = $this->rowTotalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = description::fromMap($map['description']);
        }
        if (isset($map['matrixData'])) {
            $model->matrixData = matrixData::fromMap($map['matrixData']);
        }
        if (isset($map['matrixId'])) {
            $model->matrixId = $map['matrixId'];
        }
        if (isset($map['matrixTable'])) {
            $model->matrixTable = matrixTable::fromMap($map['matrixTable']);
        }
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['rowTotalCount'])) {
            $model->rowTotalCount = $map['rowTotalCount'];
        }

        return $model;
    }
}
