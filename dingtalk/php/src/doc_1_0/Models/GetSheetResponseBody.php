<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSheetResponseBody extends Model
{
    /**
     * @example column_count
     *
     * @var int
     */
    public $columnCount;

    /**
     * @var int
     */
    public $frozenColumnCount;

    /**
     * @var int
     */
    public $frozenRowCount;

    /**
     * @example sheet_id
     *
     * @var string
     */
    public $id;

    /**
     * @example last_non_empty_column
     *
     * @var int
     */
    public $lastNonEmptyColumn;

    /**
     * @example last_non_empty_row
     *
     * @var int
     */
    public $lastNonEmptyRow;

    /**
     * @example sheet_name
     *
     * @var string
     */
    public $name;

    /**
     * @example row_count
     *
     * @var int
     */
    public $rowCount;

    /**
     * @example visible
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'columnCount' => 'columnCount',
        'frozenColumnCount' => 'frozenColumnCount',
        'frozenRowCount' => 'frozenRowCount',
        'id' => 'id',
        'lastNonEmptyColumn' => 'lastNonEmptyColumn',
        'lastNonEmptyRow' => 'lastNonEmptyRow',
        'name' => 'name',
        'rowCount' => 'rowCount',
        'visibility' => 'visibility',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnCount) {
            $res['columnCount'] = $this->columnCount;
        }
        if (null !== $this->frozenColumnCount) {
            $res['frozenColumnCount'] = $this->frozenColumnCount;
        }
        if (null !== $this->frozenRowCount) {
            $res['frozenRowCount'] = $this->frozenRowCount;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->lastNonEmptyColumn) {
            $res['lastNonEmptyColumn'] = $this->lastNonEmptyColumn;
        }
        if (null !== $this->lastNonEmptyRow) {
            $res['lastNonEmptyRow'] = $this->lastNonEmptyRow;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->rowCount) {
            $res['rowCount'] = $this->rowCount;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSheetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columnCount'])) {
            $model->columnCount = $map['columnCount'];
        }
        if (isset($map['frozenColumnCount'])) {
            $model->frozenColumnCount = $map['frozenColumnCount'];
        }
        if (isset($map['frozenRowCount'])) {
            $model->frozenRowCount = $map['frozenRowCount'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['lastNonEmptyColumn'])) {
            $model->lastNonEmptyColumn = $map['lastNonEmptyColumn'];
        }
        if (isset($map['lastNonEmptyRow'])) {
            $model->lastNonEmptyRow = $map['lastNonEmptyRow'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['rowCount'])) {
            $model->rowCount = $map['rowCount'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
