<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\ListSearchTabsByOrgIdResponseBody;

use AlibabaCloud\Tea\Model;

class searchTabResult extends Model
{
    /**
     * @var string
     */
    public $darkIcon;

    /**
     * @description This parameter is required.
     *
     * @example 2021-09-17T19:43Z
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 2021-09-17T19:43Z
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example 专辑
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
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 3333
     *
     * @var int
     */
    public $tabId;
    protected $_name = [
        'darkIcon'    => 'darkIcon',
        'gmtCreate'   => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'icon'        => 'icon',
        'name'        => 'name',
        'priority'    => 'priority',
        'source'      => 'source',
        'status'      => 'status',
        'tabId'       => 'tabId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->darkIcon) {
            $res['darkIcon'] = $this->darkIcon;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
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
        if (null !== $this->tabId) {
            $res['tabId'] = $this->tabId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return searchTabResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['darkIcon'])) {
            $model->darkIcon = $map['darkIcon'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
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
        if (isset($map['tabId'])) {
            $model->tabId = $map['tabId'];
        }

        return $model;
    }
}
