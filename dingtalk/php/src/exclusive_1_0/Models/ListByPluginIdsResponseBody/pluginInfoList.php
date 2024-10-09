<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByPluginIdsResponseBody;

use AlibabaCloud\Tea\Model;

class pluginInfoList extends Model
{
    /**
     * @var string
     */
    public $appId;

    /**
     * @var int
     */
    public $createAt;

    /**
     * @var string
     */
    public $desc;

    /**
     * @var string
     */
    public $icons;

    /**
     * @var int
     */
    public $modifiedAt;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $pcUrl;

    /**
     * @var string
     */
    public $pluginId;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'appId'      => 'appId',
        'createAt'   => 'createAt',
        'desc'       => 'desc',
        'icons'      => 'icons',
        'modifiedAt' => 'modifiedAt',
        'name'       => 'name',
        'pcUrl'      => 'pcUrl',
        'pluginId'   => 'pluginId',
        'status'     => 'status',
        'url'        => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->icons) {
            $res['icons'] = $this->icons;
        }
        if (null !== $this->modifiedAt) {
            $res['modifiedAt'] = $this->modifiedAt;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->pluginId) {
            $res['pluginId'] = $this->pluginId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pluginInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['icons'])) {
            $model->icons = $map['icons'];
        }
        if (isset($map['modifiedAt'])) {
            $model->modifiedAt = $map['modifiedAt'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['pluginId'])) {
            $model->pluginId = $map['pluginId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
