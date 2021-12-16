<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldRequest\fieldDTOList\props;
use AlibabaCloud\Tea\Model;

class fieldDTOList extends Model
{
    /**
     * @var string
     */
    public $componentName;

    /**
     * @var props
     */
    public $props;
    protected $_name = [
        'componentName' => 'componentName',
        'props'         => 'props',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentName) {
            $res['componentName'] = $this->componentName;
        }
        if (null !== $this->props) {
            $res['props'] = null !== $this->props ? $this->props->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldDTOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentName'])) {
            $model->componentName = $map['componentName'];
        }
        if (isset($map['props'])) {
            $model->props = props::fromMap($map['props']);
        }

        return $model;
    }
}
