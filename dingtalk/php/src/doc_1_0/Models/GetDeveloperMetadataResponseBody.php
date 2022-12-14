<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataResponseBody\associatedColumn;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataResponseBody\associatedRow;
use AlibabaCloud\Tea\Model;

class GetDeveloperMetadataResponseBody extends Model
{
    /**
     * @description 元数据所关联到的列
     *
     * @var associatedColumn
     */
    public $associatedColumn;

    /**
     * @description 元数据所关联到的行
     *
     * @var associatedRow
     */
    public $associatedRow;

    /**
     * @var mixed
     */
    public $value;
    protected $_name = [
        'associatedColumn' => 'associatedColumn',
        'associatedRow'    => 'associatedRow',
        'value'            => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->associatedColumn) {
            $res['associatedColumn'] = null !== $this->associatedColumn ? $this->associatedColumn->toMap() : null;
        }
        if (null !== $this->associatedRow) {
            $res['associatedRow'] = null !== $this->associatedRow ? $this->associatedRow->toMap() : null;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeveloperMetadataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['associatedColumn'])) {
            $model->associatedColumn = associatedColumn::fromMap($map['associatedColumn']);
        }
        if (isset($map['associatedRow'])) {
            $model->associatedRow = associatedRow::fromMap($map['associatedRow']);
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
