<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponseBody\result\payload;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponseBody\result\payload\locales\name;
use AlibabaCloud\Tea\Model;

class locales extends Model
{
    /**
     * @description 名称
     *
     * @var name
     */
    public $name;
    protected $_name = [
        'name' => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return locales
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }

        return $model;
    }
}
