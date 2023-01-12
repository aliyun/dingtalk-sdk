<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSheetResponseBody extends Model
{
    /**
     * @description 工作表列数。
     *
     * @var int
     */
    public $columnCount;

    /**
     * @description 工作表id
     *
     * @var string
     */
    public $id;

    /**
     * @description 最后一列非空列的位置，从0开始，表为空时返回-1。
     *
     * @var int
     */
    public $lastNonEmptyColumn;

    /**
     * @description 最后一行非空行的位置，从0开始，表为空时返回-1。
     *
     * @var int
     */
    public $lastNonEmptyRow;

    /**
     * @description 工作表名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 工作表行数。
     *
     * @var int
     */
    public $rowCount;

    /**
     * @description 工作表可见性
     * hidden: 隐藏
     * @var string
     */
    public $visibility;
    protected $_name = [
        'columnCount'        => 'columnCount',
        'id'                 => 'id',
        'lastNonEmptyColumn' => 'lastNonEmptyColumn',
        'lastNonEmptyRow'    => 'lastNonEmptyRow',
        'name'               => 'name',
        'rowCount'           => 'rowCount',
        'visibility'         => 'visibility',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnCount) {
            $res['columnCount'] = $this->columnCount;
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
