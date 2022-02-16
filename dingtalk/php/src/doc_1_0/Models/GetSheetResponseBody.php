<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSheetResponseBody extends Model
{
    /**
     * @description 工作表名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 工作表可见性
     *
     * @var string
     */
    public $visibility;

    /**
     * @description 最后一行非空行的位置，从0开始。表为空时返回-1。
     *
     * @var int
     */
    public $lastNonEmptyRow;

    /**
     * @description 最后一列非空列的位置，从0开始。表为空时返回-1。
     *
     * @var int
     */
    public $lastNonEmptyColumn;
    protected $_name = [
        'name'               => 'name',
        'visibility'         => 'visibility',
        'lastNonEmptyRow'    => 'lastNonEmptyRow',
        'lastNonEmptyColumn' => 'lastNonEmptyColumn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }
        if (null !== $this->lastNonEmptyRow) {
            $res['lastNonEmptyRow'] = $this->lastNonEmptyRow;
        }
        if (null !== $this->lastNonEmptyColumn) {
            $res['lastNonEmptyColumn'] = $this->lastNonEmptyColumn;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }
        if (isset($map['lastNonEmptyRow'])) {
            $model->lastNonEmptyRow = $map['lastNonEmptyRow'];
        }
        if (isset($map['lastNonEmptyColumn'])) {
            $model->lastNonEmptyColumn = $map['lastNonEmptyColumn'];
        }

        return $model;
    }
}
