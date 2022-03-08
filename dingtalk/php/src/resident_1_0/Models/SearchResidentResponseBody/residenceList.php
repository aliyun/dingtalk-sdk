<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\SearchResidentResponseBody;

use AlibabaCloud\Tea\Model;

class residenceList extends Model
{
    /**
     * @description 是否激活
     *
     * @var bool
     */
    public $active;

    /**
     * @description 扩展字段，如果是租客存起止时间
     *
     * @var string
     */
    public $extField;

    /**
     * @description 是否是产权人
     *
     * @var bool
     */
    public $isPropertyOwner;

    /**
     * @var string
     */
    public $name;

    /**
     * @description 业主/租客/亲友等
     *
     * @var string
     */
    public $relateType;
    protected $_name = [
        'active'          => 'active',
        'extField'        => 'extField',
        'isPropertyOwner' => 'isPropertyOwner',
        'name'            => 'name',
        'relateType'      => 'relateType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->extField) {
            $res['extField'] = $this->extField;
        }
        if (null !== $this->isPropertyOwner) {
            $res['isPropertyOwner'] = $this->isPropertyOwner;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->relateType) {
            $res['relateType'] = $this->relateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return residenceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['extField'])) {
            $model->extField = $map['extField'];
        }
        if (isset($map['isPropertyOwner'])) {
            $model->isPropertyOwner = $map['isPropertyOwner'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['relateType'])) {
            $model->relateType = $map['relateType'];
        }

        return $model;
    }
}
