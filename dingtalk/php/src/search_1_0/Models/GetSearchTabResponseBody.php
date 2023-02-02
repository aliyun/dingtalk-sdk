<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSearchTabResponseBody extends Model
{
    /**
     * @description 暗黑模式下，数据源图标，非必填，不填则使用默认图标
     *
     * @var string
     */
    public $darkIcon;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 数据源图标，非必填，不填则使用默认图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 数据源名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 数据源优先级，数值越小优先级越高
     *
     * @var int
     */
    public $priority;

    /**
     * @description 数据来源,非必填,默认来源为钉钉搜索内部引擎
     *
     * @var string
     */
    public $source;

    /**
     * @description 数据源状态，1表示上线，0表示下线
     *
     * @var int
     */
    public $status;

    /**
     * @description 数据源的id,范围为3000-4000
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
     * @return GetSearchTabResponseBody
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
