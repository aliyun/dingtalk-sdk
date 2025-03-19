<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSearchTabRequest extends Model
{
    /**
     * @var string
     */
    public $darkIcon;

    /**
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example 书籍
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $priority;

    /**
     * @var string
     */
    public $source;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'darkIcon' => 'darkIcon',
        'icon' => 'icon',
        'name' => 'name',
        'priority' => 'priority',
        'source' => 'source',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->darkIcon) {
            $res['darkIcon'] = $this->darkIcon;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSearchTabRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['darkIcon'])) {
            $model->darkIcon = $map['darkIcon'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
