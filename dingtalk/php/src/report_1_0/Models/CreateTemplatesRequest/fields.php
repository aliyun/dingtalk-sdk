<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest;

use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest\fields\dataValue;
use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $dataType;

    /**
     * @var dataValue
     */
    public $dataValue;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $need;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $order;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $sort;
    protected $_name = [
        'dataType'  => 'dataType',
        'dataValue' => 'dataValue',
        'fieldName' => 'fieldName',
        'need'      => 'need',
        'order'     => 'order',
        'sort'      => 'sort',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->dataValue) {
            $res['dataValue'] = null !== $this->dataValue ? $this->dataValue->toMap() : null;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->need) {
            $res['need'] = $this->need;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->sort) {
            $res['sort'] = $this->sort;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['dataValue'])) {
            $model->dataValue = dataValue::fromMap($map['dataValue']);
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['need'])) {
            $model->need = $map['need'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['sort'])) {
            $model->sort = $map['sort'];
        }

        return $model;
    }
}
