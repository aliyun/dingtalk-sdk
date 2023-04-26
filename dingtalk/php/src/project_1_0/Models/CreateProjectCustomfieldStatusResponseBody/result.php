<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusResponseBody\result\value;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example lookup2
     *
     * @var string
     */
    public $advCfObjectType;

    /**
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $customfieldId;

    /**
     * @example 项目进度
     *
     * @var string
     */
    public $name;

    /**
     * @example 62a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $originalId;

    /**
     * @example number
     *
     * @var string
     */
    public $type;

    /**
     * @var value[]
     */
    public $value;
    protected $_name = [
        'advCfObjectType' => 'advCfObjectType',
        'customfieldId'   => 'customfieldId',
        'name'            => 'name',
        'originalId'      => 'originalId',
        'type'            => 'type',
        'value'           => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->advCfObjectType) {
            $res['advCfObjectType'] = $this->advCfObjectType;
        }
        if (null !== $this->customfieldId) {
            $res['customfieldId'] = $this->customfieldId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->originalId) {
            $res['originalId'] = $this->originalId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->value) {
            $res['value'] = [];
            if (null !== $this->value && \is_array($this->value)) {
                $n = 0;
                foreach ($this->value as $item) {
                    $res['value'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['advCfObjectType'])) {
            $model->advCfObjectType = $map['advCfObjectType'];
        }
        if (isset($map['customfieldId'])) {
            $model->customfieldId = $map['customfieldId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['originalId'])) {
            $model->originalId = $map['originalId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = [];
                $n            = 0;
                foreach ($map['value'] as $item) {
                    $model->value[$n++] = null !== $item ? value::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
