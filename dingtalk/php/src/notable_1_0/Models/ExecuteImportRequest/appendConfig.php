<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportRequest;

use AlibabaCloud\Tea\Model;

class appendConfig extends Model
{
    /**
     * @var string[]
     */
    public $fieldIdMapping;

    /**
     * @var string[]
     */
    public $fieldMapping;

    /**
     * @var int
     */
    public $headerRow;

    /**
     * @var string
     */
    public $srcSheetName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tableId;
    protected $_name = [
        'fieldIdMapping' => 'fieldIdMapping',
        'fieldMapping' => 'fieldMapping',
        'headerRow' => 'headerRow',
        'srcSheetName' => 'srcSheetName',
        'tableId' => 'tableId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldIdMapping) {
            $res['fieldIdMapping'] = $this->fieldIdMapping;
        }
        if (null !== $this->fieldMapping) {
            $res['fieldMapping'] = $this->fieldMapping;
        }
        if (null !== $this->headerRow) {
            $res['headerRow'] = $this->headerRow;
        }
        if (null !== $this->srcSheetName) {
            $res['srcSheetName'] = $this->srcSheetName;
        }
        if (null !== $this->tableId) {
            $res['tableId'] = $this->tableId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return appendConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldIdMapping'])) {
            $model->fieldIdMapping = $map['fieldIdMapping'];
        }
        if (isset($map['fieldMapping'])) {
            $model->fieldMapping = $map['fieldMapping'];
        }
        if (isset($map['headerRow'])) {
            $model->headerRow = $map['headerRow'];
        }
        if (isset($map['srcSheetName'])) {
            $model->srcSheetName = $map['srcSheetName'];
        }
        if (isset($map['tableId'])) {
            $model->tableId = $map['tableId'];
        }

        return $model;
    }
}
