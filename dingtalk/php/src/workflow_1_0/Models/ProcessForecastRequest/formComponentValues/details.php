<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastRequest\formComponentValues;

use AlibabaCloud\Tea\Model;

class details extends Model
{
    /**
     * @description 控件id
     *
     * @var string
     */
    public $id;

    /**
     * @description 控件别名
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 控件名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 控件值
     *
     * @var string
     */
    public $value;

    /**
     * @description 控件扩展值
     *
     * @var string
     */
    public $extValue;

    /**
     * @var \AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastRequest\formComponentValues\details\details[]
     */
    public $details;
    protected $_name = [
        'id'       => 'id',
        'bizAlias' => 'bizAlias',
        'name'     => 'name',
        'value'    => 'value',
        'extValue' => 'extValue',
        'details'  => 'details',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->extValue) {
            $res['extValue'] = $this->extValue;
        }
        if (null !== $this->details) {
            $res['details'] = [];
            if (null !== $this->details && \is_array($this->details)) {
                $n = 0;
                foreach ($this->details as $item) {
                    $res['details'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return details
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['extValue'])) {
            $model->extValue = $map['extValue'];
        }
        if (isset($map['details'])) {
            if (!empty($map['details'])) {
                $model->details = [];
                $n              = 0;
                foreach ($map['details'] as $item) {
                    $model->details[$n++] = null !== $item ? \AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastRequest\formComponentValues\details\details::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
